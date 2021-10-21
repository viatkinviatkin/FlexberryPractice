export default {
  projections: {
    OrderItembugfix: {
      product: {
        __caption__: 'product',
        name: {
          __caption__: 'name'
        }
      },
      amount: {
        __caption__: 'amount'
      },
      priceWTaxes: {
        __caption__: 'priceWTaxes'
      },
      totalSum: {
        __caption__: 'totalSum'
      }
    },
    OrderItemE: {
      amount: {
        __caption__: 'amount'
      },
      totalSum: {
        __caption__: 'totalSum'
      },
      priceWTaxes: {
        __caption__: 'priceWTaxes'
      },
      product: {
        __caption__: 'product',
        productCode: {
          __caption__: 'productCode'
        },
        name: {
          __caption__: 'name'
        }
      }
    },
    OrderItemInOrderL: {
      amount: {
        __caption__: 'amount'
      },
      priceWTaxes: {
        __caption__: 'priceWTaxes'
      }
    }
  },
  validations: {
    amount: {
      __caption__: 'amount'
    },
    priceWTaxes: {
      __caption__: 'priceWTaxes'
    },
    totalSum: {
      __caption__: 'totalSum'
    },
    product: {
      __caption__: 'product'
    },
    order: {
      __caption__: 'order'
    }
  }
};
