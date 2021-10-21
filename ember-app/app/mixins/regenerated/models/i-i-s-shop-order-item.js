import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  amount: DS.attr('number'),
  priceWTaxes: DS.attr('decimal'),
  totalSum: DS.attr('decimal'),
  product: DS.belongsTo('i-i-s-shop-product', { inverse: null, async: false }),
  order: DS.belongsTo('i-i-s-shop-order', { inverse: 'orderItem', async: false })
});

export let ValidationRules = {
  amount: {
    descriptionKey: 'models.i-i-s-shop-order-item.validations.amount.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true, positive:true }),
      validator('check-product-amount', {
        showSuggestions: false,
       }),
    ],
  },
  priceWTaxes: {
    descriptionKey: 'models.i-i-s-shop-order-item.validations.priceWTaxes.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, positive:true }),
    ],
  },
  totalSum: {
    descriptionKey: 'models.i-i-s-shop-order-item.validations.totalSum.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, positive:true }),
    ],
  },
  product: {
    descriptionKey: 'models.i-i-s-shop-order-item.validations.product.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  order: {
    descriptionKey: 'models.i-i-s-shop-order-item.validations.order.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('OrderItembugfix', 'i-i-s-shop-order-item', {
    product: belongsTo('i-i-s-shop-product', '~', {
      name: attr('~', { index: 0, hidden: true })
    }, { index: 1, hidden: true }),
    amount: attr('количество', { index: 2 }),
    priceWTaxes: attr('Цена с налогом', { index: 3 }),
    totalSum: attr('Сумма', { index: 4 })
  });

  modelClass.defineProjection('OrderItemE', 'i-i-s-shop-order-item', {
    amount: attr('Количество', { index: 0 }),
    totalSum: attr('Сумма по позиции', { index: 2 }),
    priceWTaxes: attr('Цена с налогом', { index: 3 }),
    product: belongsTo('i-i-s-shop-product', 'Товар', {
      productCode: attr('~', { index: 4, hidden: true }),
      name: attr('~', { index: 5, hidden: true })
    }, { index: 1, displayMemberPath: 'name' })
  });

  modelClass.defineProjection('OrderItemInOrderL', 'i-i-s-shop-order-item', {
    amount: attr('~', { index: 0, hidden: true }),
    priceWTaxes: attr('~', { index: 1, hidden: true })
  });
};
