import { buildValidations } from 'ember-cp-validations';
import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';
import OfflineModelMixin from 'ember-flexberry-data/mixins/offline-model';
import { computed,observer  } from '@ember/object';
import { once } from '@ember/runloop';
import { on } from '@ember/object/evented';

import {
  defineProjections,
  ValidationRules,
  Model as OrderItemMixin
} from '../mixins/regenerated/models/i-i-s-shop-order-item';

const Validations = buildValidations(ValidationRules, {
  dependentKeys: ['model.i18n.locale'],
});

let Model = EmberFlexberryDataModel.extend(OfflineModelMixin, OrderItemMixin, Validations, {
  actualTotalSum: computed('priceWTaxesComp', 'amount', function() {
    const price = Number(this.get('priceWTaxesComp') || 0);
    const amount = Number(this.get('amount') || 0);
    return (price * amount).toFixed(2);
  }),
  
  priceWTaxesComp: computed('product.price', function() {
    const price = Number(this.get('product.price') || 0);
    const tax = 1.1;
    return (price*tax).toFixed(2);
  }),

  // Цена с налогом
  _priceWTaxesChanged: on('init', observer('product', function() {
    console.log('зашел')
    if (!this.get('order.isPaidOrCanceled')) {
      console.log('я пересчитываю')
      once(this, 'priceWTaxesComp');
    }
  })),
});

defineProjections(Model);

export default Model;
