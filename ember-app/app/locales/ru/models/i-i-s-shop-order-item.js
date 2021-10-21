export default {
  projections: {
    OrderItembugfix: {
      product: {
        __caption__: 'Товар',
        name: {
          __caption__: '~'
        }
      },
      amount: {
        __caption__: 'количество'
      },
      priceWTaxes: {
        __caption__: 'Цена с налогом'
      },
      totalSum: {
        __caption__: 'Сумма'
      }
    },
    OrderItemE: {
      amount: {
        __caption__: 'Количество'
      },
      totalSum: {
        __caption__: 'Сумма по позиции'
      },
      priceWTaxes: {
        __caption__: 'Цена с налогом'
      },
      product: {
        __caption__: 'Товар',
        productCode: {
          __caption__: '~'
        },
        name: {
          __caption__: 'Товар'
        }
      }
    },
    OrderItemInOrderL: {
      amount: {
        __caption__: '~'
      },
      priceWTaxes: {
        __caption__: '~'
      }
    }
  },
  validations: {
    amount: {
      __caption__: 'Количество'
    },
    priceWTaxes: {
      __caption__: 'Цена с налогом'
    },
    totalSum: {
      __caption__: 'Сумма по позиции'
    },
    product: {
      __caption__: 'Товар'
    },
    order: {
      __caption__: 'order'
    }
  }
};
