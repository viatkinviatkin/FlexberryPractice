import $ from 'jquery';
import { buildValidations } from 'ember-cp-validations';
import { computed } from '@ember/object';
import {
  defineBaseModel,
  defineProjections,
  ValidationRules,
  Model as InvoiceMixin
} from '../mixins/regenerated/models/i-i-s-shop-invoice';

import DocumentModel from './i-i-s-shop-document';
import { ValidationRules as ParentValidationRules } from '../mixins/regenerated/models/i-i-s-shop-document';

const Validations = buildValidations($.extend({}, ParentValidationRules, ValidationRules), {
  dependentKeys: ['model.i18n.locale'],
});

let Model = DocumentModel.extend(InvoiceMixin, Validations, {

    getOrderValue: computed('order', function() {
      return this.get('order.totalSum')
    }),

    getWeightSum: computed('invoiceItem.@each.{weight}', function() {
      let orderItemObj=this.get('invoiceItem')
      if(orderItemObj){
        return orderItemObj.reduce((sum, item) => {
          const totalSum = Number(item.get('weight') || 0);
          return sum + totalSum;
        }, 0);
      }
      else
        return 0;
     
      
    }),

    setShipmentDateTime: computed('shipmentDateTime', function() {
     
      return this.get('shipmentDateTime') 
    }),

   
   
 

});

defineBaseModel(Model);
defineProjections(Model);

export default Model;
