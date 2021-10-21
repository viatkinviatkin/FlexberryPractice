export default {
  projections: {
    InvoiceItemE: {
      amount: {
        __caption__: 'Количество'
      },
      weight: {
        __caption__: 'Вес (кг)'
      },
      price: {
        __caption__: 'Цена'
      },
      totalSum: {
        __caption__: 'Сумма позиции'
      },
      product: {
        __caption__: '~',
        name: {
          __caption__: '~'
        }
      }
    }
  },
  validations: {
    amount: {
      __caption__: 'Количество'
    },
    weight: {
      __caption__: 'Вес (кг)'
    },
    price: {
      __caption__: 'Цена'
    },
    totalSum: {
      __caption__: 'Сумма позиции'
    },
    product: {
      __caption__: '~'
    },
    invoice: {
      __caption__: 'invoice'
    }
  }
};
