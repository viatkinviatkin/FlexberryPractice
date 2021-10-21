import $ from 'jquery';
import { buildValidations } from 'ember-cp-validations';
import { computed } from '@ember/object';
import OrderStatusEnum from '../enums/i-i-s-shop-order-status';
import {
  defineBaseModel,
  defineProjections,
  ValidationRules,
  Model as OrderMixin
} from '../mixins/regenerated/models/i-i-s-shop-order';

import DocumentModel from './i-i-s-shop-document';
import { ValidationRules as ParentValidationRules } from '../mixins/regenerated/models/i-i-s-shop-document';

const Validations = buildValidations($.extend({}, ParentValidationRules, ValidationRules), {
  dependentKeys: ['model.i18n.locale'],
});

let Model = DocumentModel.extend(OrderMixin, Validations, {
  

  actualTotalSum: computed('orderItem.@each.{amount,actualTotalSum}', function() {
    return this.get('orderItem').reduce((sum, item) => {
      const totalSum = Number(item.get('actualTotalSum') || 0);
      return sum + totalSum;
    }, 0);
  }),
  isPaidOrCanceled: computed('status', function() {
    const status = this.get('status');
    const dirtyAttributes = this.get('hasDirtyAttributes');
    console.log(status)
    console.log(dirtyAttributes)
    let isPaidOrCanceledValue =  status === OrderStatusEnum.Paid || status === OrderStatusEnum.Canceled
    return isPaidOrCanceledValue && !dirtyAttributes;
  })
   


});

defineBaseModel(Model);
defineProjections(Model);

export default Model;
