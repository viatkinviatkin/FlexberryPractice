import { buildValidations } from 'ember-cp-validations';
import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';
import OfflineModelMixin from 'ember-flexberry-data/mixins/offline-model';
import { computed } from '@ember/object';

import {
  defineProjections,
  ValidationRules,
  Model as ProductMixin
} from '../mixins/regenerated/models/i-i-s-shop-product';

const Validations = buildValidations(ValidationRules, {
  dependentKeys: ['model.i18n.locale'],
});

let Model = EmberFlexberryDataModel.extend(OfflineModelMixin, ProductMixin, Validations, {
  nameWCode: computed('productCode', 'name', function() {
    let productCode = this.get('productCode');
    let productName = this.get('name');
   
    return `${productCode}. Наименование товара ${productName}`;
  }),
});

defineProjections(Model);

export default Model;
