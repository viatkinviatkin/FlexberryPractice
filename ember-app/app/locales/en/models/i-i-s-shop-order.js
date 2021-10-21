export default {
  projections: {
    OrderE: {
      number: {
        __caption__: 'number'
      },
      status: {
        __caption__: 'status'
      },
      createDate: {
        __caption__: 'createDate'
      },
      manager: {
        __caption__: 'manager',
        lastName: {
          __caption__: 'lastName'
        },
        middleName: {
          __caption__: 'middleName'
        },
        firstName: {
          __caption__: 'firstName'
        }
      },
      totalSum: {
        __caption__: 'totalSum'
      },
      paymentDate: {
        __caption__: 'paymentDate'
      },
      shipmentDate: {
        __caption__: 'shipmentDate'
      },
      orderItem: {
        __caption__: 'orderItem',
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
      }
    },
    OrderL: {
      number: {
        __caption__: 'number'
      },
      status: {
        __caption__: 'status'
      },
      createDate: {
        __caption__: 'createDate'
      },
      manager: {
        __caption__: 'manager',
        lastName: {
          __caption__: 'lastName'
        }
      },
      totalSum: {
        __caption__: 'totalSum'
      },
      paymentDate: {
        __caption__: 'paymentDate'
      },
      shipmentDate: {
        __caption__: 'shipmentDate'
      },
      orderItem: {
        __caption__: 'orderItem',
        amount: {
          __caption__: 'amount'
        },
        priceWTaxes: {
          __caption__: 'priceWTaxes'
        }
      }
    }
  },
  validations: {
    status: {
      __caption__: 'status'
    },
    shipmentDate: {
      __caption__: 'shipmentDate'
    },
    paymentDate: {
      __caption__: 'paymentDate'
    },
    totalSum: {
      __caption__: 'totalSum'
    },
    manager: {
      __caption__: 'manager'
    },
    orderItem: {
      __caption__: 'orderItem'
    }
  }
};
