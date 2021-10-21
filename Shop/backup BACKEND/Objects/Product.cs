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
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Product.
    /// </summary>
    // *** Start programmer edit section *** (Product CustomAttributes)

    // *** End programmer edit section *** (Product CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ProductE", new string[] {
            "ProductCode as \'Код товара\'",
            "Name as \'Наименование\'",
            "Measure as \'Единица измерения\'",
            "Description as \'Описание\'",
            "Price as \'Цена за ед.\'",
            "Weight as \'Вес за кг\'"})]
    [View("ProductL", new string[] {
            "ProductCode as \'Код товара\'",
            "Name as \'Наименование\'",
            "Measure as \'Единица измерения\'",
            "Description as \'Описание\'",
            "Price as \'Цена за ед.\'",
            "Weight as \'Вес в кг\'"})]
    public class Product : ICSSoft.STORMNET.DataObject
    {
        
        private int fProductCode = 1;
        
        private string fName;
        
        private string fMeasure;
        
        private string fDescription;
        
        private double fPrice;
        
        private double fWeight;
        
        // *** Start programmer edit section *** (Product CustomMembers)

        // *** End programmer edit section *** (Product CustomMembers)

        
        /// <summary>
        /// ProductCode.
        /// </summary>
        // *** Start programmer edit section *** (Product.ProductCode CustomAttributes)

        // *** End programmer edit section *** (Product.ProductCode CustomAttributes)
        [DisableInsertProperty(true)]
        [NotNull()]
        public virtual int ProductCode
        {
            get
            {
                // *** Start programmer edit section *** (Product.ProductCode Get start)

                // *** End programmer edit section *** (Product.ProductCode Get start)
                int result = this.fProductCode;
                // *** Start programmer edit section *** (Product.ProductCode Get end)

                // *** End programmer edit section *** (Product.ProductCode Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Product.ProductCode Set start)

                // *** End programmer edit section *** (Product.ProductCode Set start)
                this.fProductCode = value;
                // *** Start programmer edit section *** (Product.ProductCode Set end)

                // *** End programmer edit section *** (Product.ProductCode Set end)
            }
        }
        
        /// <summary>
        /// Name.
        /// </summary>
        // *** Start programmer edit section *** (Product.Name CustomAttributes)

        // *** End programmer edit section *** (Product.Name CustomAttributes)
        [StrLen(255)]
        public virtual string Name
        {
            get
            {
                // *** Start programmer edit section *** (Product.Name Get start)

                // *** End programmer edit section *** (Product.Name Get start)
                string result = this.fName;
                // *** Start programmer edit section *** (Product.Name Get end)

                // *** End programmer edit section *** (Product.Name Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Product.Name Set start)

                // *** End programmer edit section *** (Product.Name Set start)
                this.fName = value;
                // *** Start programmer edit section *** (Product.Name Set end)

                // *** End programmer edit section *** (Product.Name Set end)
            }
        }
        
        /// <summary>
        /// Measure.
        /// </summary>
        // *** Start programmer edit section *** (Product.Measure CustomAttributes)

        // *** End programmer edit section *** (Product.Measure CustomAttributes)
        [StrLen(255)]
        public virtual string Measure
        {
            get
            {
                // *** Start programmer edit section *** (Product.Measure Get start)

                // *** End programmer edit section *** (Product.Measure Get start)
                string result = this.fMeasure;
                // *** Start programmer edit section *** (Product.Measure Get end)

                // *** End programmer edit section *** (Product.Measure Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Product.Measure Set start)

                // *** End programmer edit section *** (Product.Measure Set start)
                this.fMeasure = value;
                // *** Start programmer edit section *** (Product.Measure Set end)

                // *** End programmer edit section *** (Product.Measure Set end)
            }
        }
        
        /// <summary>
        /// Description.
        /// </summary>
        // *** Start programmer edit section *** (Product.Description CustomAttributes)

        // *** End programmer edit section *** (Product.Description CustomAttributes)
        [StrLen(255)]
        public virtual string Description
        {
            get
            {
                // *** Start programmer edit section *** (Product.Description Get start)

                // *** End programmer edit section *** (Product.Description Get start)
                string result = this.fDescription;
                // *** Start programmer edit section *** (Product.Description Get end)

                // *** End programmer edit section *** (Product.Description Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Product.Description Set start)

                // *** End programmer edit section *** (Product.Description Set start)
                this.fDescription = value;
                // *** Start programmer edit section *** (Product.Description Set end)

                // *** End programmer edit section *** (Product.Description Set end)
            }
        }
        
        /// <summary>
        /// Price.
        /// </summary>
        // *** Start programmer edit section *** (Product.Price CustomAttributes)

        // *** End programmer edit section *** (Product.Price CustomAttributes)
        public virtual double Price
        {
            get
            {
                // *** Start programmer edit section *** (Product.Price Get start)

                // *** End programmer edit section *** (Product.Price Get start)
                double result = this.fPrice;
                // *** Start programmer edit section *** (Product.Price Get end)

                // *** End programmer edit section *** (Product.Price Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Product.Price Set start)

                // *** End programmer edit section *** (Product.Price Set start)
                this.fPrice = value;
                // *** Start programmer edit section *** (Product.Price Set end)

                // *** End programmer edit section *** (Product.Price Set end)
            }
        }
        
        /// <summary>
        /// Weight.
        /// </summary>
        // *** Start programmer edit section *** (Product.Weight CustomAttributes)

        // *** End programmer edit section *** (Product.Weight CustomAttributes)
        public virtual double Weight
        {
            get
            {
                // *** Start programmer edit section *** (Product.Weight Get start)

                // *** End programmer edit section *** (Product.Weight Get start)
                double result = this.fWeight;
                // *** Start programmer edit section *** (Product.Weight Get end)

                // *** End programmer edit section *** (Product.Weight Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Product.Weight Set start)

                // *** End programmer edit section *** (Product.Weight Set start)
                this.fWeight = value;
                // *** Start programmer edit section *** (Product.Weight Set end)

                // *** End programmer edit section *** (Product.Weight Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ProductE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ProductE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ProductE", typeof(IIS.Shop.Product));
                }
            }
            
            /// <summary>
            /// "ProductL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ProductL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ProductL", typeof(IIS.Shop.Product));
                }
            }
        }
    }
}