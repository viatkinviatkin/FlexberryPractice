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
    /// Storehouse.
    /// </summary>
    // *** Start programmer edit section *** (Storehouse CustomAttributes)

    // *** End programmer edit section *** (Storehouse CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("StorehouseE", new string[] {
            "Number as \'Номер\'",
            "Address as \'Адрес\'",
            "Storekeeper as \'Кладовщик\'",
            "Storekeeper.LastName as \'\'"}, Hidden=new string[] {
            "Storekeeper.LastName"})]
    [AssociatedDetailViewAttribute("StorehouseE", "StoreProduct", "StoreProductE", true, "", "Список товаров", true, new string[] {
            ""})]
    [MasterViewDefineAttribute("StorehouseE", "Storekeeper", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "LastName")]
    [View("StorehouseL", new string[] {
            "Number as \'Номер\'",
            "Address as \'Адрес\'",
            "Storekeeper.LastName as \'Кладовщик\'"})]
    public class Storehouse : ICSSoft.STORMNET.DataObject
    {
        
        private int fNumber = 1;
        
        private string fAddress;
        
        private IIS.Shop.Employee fStorekeeper;
        
        private IIS.Shop.DetailArrayOfStoreProduct fStoreProduct;
        
        // *** Start programmer edit section *** (Storehouse CustomMembers)

        // *** End programmer edit section *** (Storehouse CustomMembers)

        
        /// <summary>
        /// Number.
        /// </summary>
        // *** Start programmer edit section *** (Storehouse.Number CustomAttributes)

        // *** End programmer edit section *** (Storehouse.Number CustomAttributes)
        [DisableInsertProperty(true)]
        [NotNull()]
        public virtual int Number
        {
            get
            {
                // *** Start programmer edit section *** (Storehouse.Number Get start)

                // *** End programmer edit section *** (Storehouse.Number Get start)
                int result = this.fNumber;
                // *** Start programmer edit section *** (Storehouse.Number Get end)

                // *** End programmer edit section *** (Storehouse.Number Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Storehouse.Number Set start)

                // *** End programmer edit section *** (Storehouse.Number Set start)
                this.fNumber = value;
                // *** Start programmer edit section *** (Storehouse.Number Set end)

                // *** End programmer edit section *** (Storehouse.Number Set end)
            }
        }
        
        /// <summary>
        /// Address.
        /// </summary>
        // *** Start programmer edit section *** (Storehouse.Address CustomAttributes)

        // *** End programmer edit section *** (Storehouse.Address CustomAttributes)
        [StrLen(255)]
        public virtual string Address
        {
            get
            {
                // *** Start programmer edit section *** (Storehouse.Address Get start)

                // *** End programmer edit section *** (Storehouse.Address Get start)
                string result = this.fAddress;
                // *** Start programmer edit section *** (Storehouse.Address Get end)

                // *** End programmer edit section *** (Storehouse.Address Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Storehouse.Address Set start)

                // *** End programmer edit section *** (Storehouse.Address Set start)
                this.fAddress = value;
                // *** Start programmer edit section *** (Storehouse.Address Set end)

                // *** End programmer edit section *** (Storehouse.Address Set end)
            }
        }
        
        /// <summary>
        /// Storehouse.
        /// </summary>
        // *** Start programmer edit section *** (Storehouse.Storekeeper CustomAttributes)

        // *** End programmer edit section *** (Storehouse.Storekeeper CustomAttributes)
        [PropertyStorage(new string[] {
                "Storekeeper"})]
        public virtual IIS.Shop.Employee Storekeeper
        {
            get
            {
                // *** Start programmer edit section *** (Storehouse.Storekeeper Get start)

                // *** End programmer edit section *** (Storehouse.Storekeeper Get start)
                IIS.Shop.Employee result = this.fStorekeeper;
                // *** Start programmer edit section *** (Storehouse.Storekeeper Get end)

                // *** End programmer edit section *** (Storehouse.Storekeeper Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Storehouse.Storekeeper Set start)

                // *** End programmer edit section *** (Storehouse.Storekeeper Set start)
                this.fStorekeeper = value;
                // *** Start programmer edit section *** (Storehouse.Storekeeper Set end)

                // *** End programmer edit section *** (Storehouse.Storekeeper Set end)
            }
        }
        
        /// <summary>
        /// Storehouse.
        /// </summary>
        // *** Start programmer edit section *** (Storehouse.StoreProduct CustomAttributes)

        // *** End programmer edit section *** (Storehouse.StoreProduct CustomAttributes)
        public virtual IIS.Shop.DetailArrayOfStoreProduct StoreProduct
        {
            get
            {
                // *** Start programmer edit section *** (Storehouse.StoreProduct Get start)

                // *** End programmer edit section *** (Storehouse.StoreProduct Get start)
                if ((this.fStoreProduct == null))
                {
                    this.fStoreProduct = new IIS.Shop.DetailArrayOfStoreProduct(this);
                }
                IIS.Shop.DetailArrayOfStoreProduct result = this.fStoreProduct;
                // *** Start programmer edit section *** (Storehouse.StoreProduct Get end)

                // *** End programmer edit section *** (Storehouse.StoreProduct Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Storehouse.StoreProduct Set start)

                // *** End programmer edit section *** (Storehouse.StoreProduct Set start)
                this.fStoreProduct = value;
                // *** Start programmer edit section *** (Storehouse.StoreProduct Set end)

                // *** End programmer edit section *** (Storehouse.StoreProduct Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "StorehouseE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View StorehouseE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("StorehouseE", typeof(IIS.Shop.Storehouse));
                }
            }
            
            /// <summary>
            /// "StorehouseL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View StorehouseL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("StorehouseL", typeof(IIS.Shop.Storehouse));
                }
            }
        }
    }
}