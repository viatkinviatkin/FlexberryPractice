import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  amount: DS.attr('number'),
  product: DS.belongsTo('i-i-s-shop-product', { inverse: null, async: false }),
  storehouse: DS.belongsTo('i-i-s-shop-storehouse', { inverse: 'storeProduct', async: false })
});

export let ValidationRules = {
  amount: {
    descriptionKey: 'models.i-i-s-shop-store-product.validations.amount.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  product: {
    descriptionKey: 'models.i-i-s-shop-store-product.validations.product.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  storehouse: {
    descriptionKey: 'models.i-i-s-shop-store-product.validations.storehouse.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('StoreProductE', 'i-i-s-shop-store-product', {
    amount: attr('Количество', { index: 1 }),
    product: belongsTo('i-i-s-shop-product', 'Товар', {
      name: attr('~', { index: 2, hidden: true })
    }, { index: 0, displayMemberPath: 'name' })
  });
};
