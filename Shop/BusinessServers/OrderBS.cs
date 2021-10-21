﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Shop
{
    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Business;
    using ICSSoft.STORMNET.FunctionalLanguage;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Xml;
    using System.Linq;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// OrderBS.
    /// </summary>
    // *** Start programmer edit section *** (OrderBS CustomAttributes)

    // *** End programmer edit section *** (OrderBS CustomAttributes)
    [ICSSoft.STORMNET.AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class OrderBS : ICSSoft.STORMNET.Business.BusinessServer
    {

        // *** Start programmer edit section *** (OrderBS CustomMembers)

        // *** End programmer edit section *** (OrderBS CustomMembers)
        /// <summary>
        /// Перевод заказа в статус "Оплачено"
        /// </summary>
        /// <param name="UpdatedObject">Заказ</param>
        /// <returns>Список измененных объектов (заказ + товары на складе)</returns>
        private static DataObject[] changeOrderStatusPaid(IIS.Shop.Order UpdatedObject)
        {
            // Определим массив, который будем возвращать для обновления.
            DataObject[] ret = new DataObject[0];

            // Построим ограничение и вычитаем все объекты StoreProduct, которые нам подходят.
            Order order = UpdatedObject;
            Function lf = null;

            for (int i = 0; i < order.OrderItem.Count; i++)
            {
                Function storeProduct = FunctionBuilder.BuildEquals<StoreProduct>(x => x.Product, order.OrderItem[i].Product);
                if (order.OrderItem[i].Product != null)
                {
                    lf = lf == null ? storeProduct : FunctionBuilder.BuildOr(lf, storeProduct);
                }
            }

            LoadingCustomizationStruct lcs = LoadingCustomizationStruct.GetSimpleStruct(typeof(StoreProduct), "StoreProductE");
            lcs.LimitFunction = lf;

            // Сортировка по номеру склада
            var sortColumns = new List<ColumnsSortDef>();
            sortColumns.Add(new ColumnsSortDef("Storehouse.Number", SortOrder.Asc));
            lcs.ColumnsSort = sortColumns.ToArray();

            DataObject[] objs = DataServiceProvider.DataService.LoadObjects(lcs);

            // Разместим вычитанные объекты в отсортированном списке для удобного доступа в дальнейшем.
            SortedList sl = new SortedList();
            for (int i = 0; i < objs.Length; i++)
            {
                var primaryKey = ((StoreProduct)objs[i]).Product.__PrimaryKey;
                ArrayList productList;
                if (sl.ContainsKey(primaryKey))
                {
                    productList = (ArrayList)sl[primaryKey];
                    productList.Add(objs[i]);
                }
                else
                {
                    productList = new ArrayList();
                    productList.Add(objs[i]);
                    sl.Add(primaryKey, productList);
                }
            }

            // Определим строчку для сообщения об ошибке. 
            string errStr = string.Empty;
            ArrayList retObjs = new ArrayList();

            // Проверим наличие товара на складах, если не хватает, то выдадим сообщение об ошибке, если хватает, то вычитаем количество.
            for (int i = 0; i < order.OrderItem.Count; i++)
            {
                if (sl.ContainsKey(order.OrderItem[i].Product.__PrimaryKey))
                {
                    ArrayList arl = ((ArrayList)sl[order.OrderItem[i].Product.__PrimaryKey]);

                    int productTotalCount = 0;
                    for (int j = 0; j < arl.Count; j++)
                    {
                        productTotalCount += ((StoreProduct)arl[j]).Amount;
                    }

                    if (productTotalCount < order.OrderItem[i].Amount)
                    {
                        errStr += " Не хватает товара \"" + order.OrderItem[i].Product.Name
                            + "\" в наличии: " + productTotalCount
                            + ", требуется " + order.OrderItem[i].Amount
                            + Environment.NewLine;
                    }
                    else
                    {
                        int count = order.OrderItem[i].Amount;
                        for (int j = 0; j < arl.Count; j++)
                        {
                            if (count > 0 && ((StoreProduct)arl[j]).Amount > count)
                            {
                                ((StoreProduct)arl[j]).Amount -= count;
                                count = 0;
                                retObjs.Add(arl[j]);
                            }
                            else if (count > 0)
                            {
                                count -= ((StoreProduct)arl[j]).Amount;
                                ((StoreProduct)arl[j]).SetStatus(ObjectStatus.Deleted);
                                retObjs.Add(arl[j]);
                            }
                        }
                    }
                }
                else
                {
                    errStr += "Товар	\"" +
                    order.OrderItem[i].Product.Name + "\" в наличии отсутствует." + Environment.NewLine;
                }

                // В случае, если чего-то не хватило, сообщаем об этом пользователю.
                if (errStr != string.Empty)
                {
                    throw new Exception(errStr);
                }

                // Если всё нормально, то возвращаем массив объектов, которые надо обновить.
                ret = new DataObject[retObjs.Count]; retObjs.CopyTo(ret, 0);
            }

            return ret;
        }

        // *** Start programmer edit section *** (OnUpdateOrder CustomAttributes)

        // *** End programmer edit section *** (OnUpdateOrder CustomAttributes)
        public virtual ICSSoft.STORMNET.DataObject[] OnUpdateOrder(IIS.Shop.Order UpdatedObject)
        {
            // *** Start programmer edit section *** (OnUpdateOrder)
            DataObject[] result = new DataObject[0];

            if ((UpdatedObject.GetStatus() == ObjectStatus.Created
                || UpdatedObject.GetStatus() == ObjectStatus.Altered)
                && Array.IndexOf(UpdatedObject.GetAlteredPropertyNames(), "Status") >= 0
                && UpdatedObject.Status == OrderStatus.Paid)
            {
                result = changeOrderStatusPaid(UpdatedObject);

                CreateInvoice(UpdatedObject);
               
            }

            return result;
            // *** End programmer edit section *** (OnUpdateOrder)
        }

        public static void CreateInvoice(IIS.Shop.Order order )
        {
            try
            {
                Invoice newInvoice = new Invoice
                {
                    Status = InvoiceStatus.New,
                    CreateDate = order.CreateDate,
                    Order = order,
                    ResponsiblePerson = order.Manager,
                    
                };


                foreach (OrderItem orderItem in order.OrderItem)
                {
                   
                    DataServiceProvider.DataService.LoadObject("ProductE", orderItem.Product);
                    newInvoice.InvoiceItem.Add(new InvoiceItem
                    {
                        Amount = orderItem.Amount,
                        Product = orderItem.Product,
                        TotalSum = orderItem.TotalSum,
                        Weight = orderItem.Product.Weight * orderItem.Amount,
                        Price = orderItem.PriceWTaxes
                    });
                }
               

                ICSSoft.STORMNET.DataObject saveObj = (DataObject)newInvoice;
                DataServiceProvider.DataService.UpdateObject(saveObj);
            }
            catch
            {
                Console.WriteLine("Received an error while creating an Invoice object");
            }
        }
    }
}
