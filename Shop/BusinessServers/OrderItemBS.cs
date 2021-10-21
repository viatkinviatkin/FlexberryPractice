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
    using System;
    using System.Xml;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// OrderItemBS.
    /// </summary>
    // *** Start programmer edit section *** (OrderItemBS CustomAttributes)

    // *** End programmer edit section *** (OrderItemBS CustomAttributes)
    [ICSSoft.STORMNET.AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class OrderItemBS : ICSSoft.STORMNET.Business.BusinessServer
    {

        // *** Start programmer edit section *** (OrderItemBS CustomMembers)

        // *** End programmer edit section *** (OrderItemBS CustomMembers)
        public const int TAXES = 333;

        // *** Start programmer edit section *** (OnUpdateOrderItem CustomAttributes)

        // *** End programmer edit section *** (OnUpdateOrderItem CustomAttributes)
        public virtual ICSSoft.STORMNET.DataObject[] OnUpdateOrderItem(IIS.Shop.OrderItem UpdatedObject)
        {

            ICSSoft.STORMNET.ObjectStatus objectStatus = UpdatedObject.GetStatus();
            // *** Start programmer edit section *** (OnUpdateOrderItem)
            if (objectStatus == ICSSoft.STORMNET.ObjectStatus.Created || objectStatus == ICSSoft.STORMNET.ObjectStatus.Altered)
            {
                var product = new IIS.Shop.Product();

                product.SetExistObjectPrimaryKey(UpdatedObject.Product.__PrimaryKey);
                DataService.LoadObject(IIS.Shop.Product.Views.ProductL, product);

                double coefficient = TAXES;

                UpdatedObject.PriceWTaxes = product.Price +TAXES;
                UpdatedObject.TotalSum = product.Price * UpdatedObject.Amount;
                
            }



            return new ICSSoft.STORMNET.DataObject[0];
            // *** End programmer edit section *** (OnUpdateOrderItem)
        }
    }
}