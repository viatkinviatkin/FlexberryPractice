import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';
import OrderStatusEnum from '../../../enums/i-i-s-shop-order-status';
import { computed } from '@ember/object';
export let Model = Mixin.create({
  status: DS.attr('i-i-s-shop-order-status', { defaultValue: OrderStatusEnum.New }),
  shipmentDate: DS.attr('date'),
  paymentDate: DS.attr('date'),
  /**
    Non-stored property.

    @property totalSum
  */
  totalSum: DS.attr('decimal'),
  /**
    Method to set non-stored property.
    Please, use code below in model class (outside of this mixin) otherwise it will be replaced during regeneration of models.
    Please, implement 'totalSumCompute' method in model class (outside of this mixin) if you want to compute value of 'totalSum' property.

    @method _totalSumCompute
    @private
    @example
      ```javascript
      _totalSumChanged: on('init', observer('totalSum', function() {
        once(this, '_totalSumCompute');
      }))
      ```
  */
  _totalSumCompute: function() {
    let result = (this.totalSumCompute && typeof this.totalSumCompute === 'function') ? this.totalSumCompute() : null;
    this.set('totalSum', result);
  },
  manager: DS.belongsTo('i-i-s-shop-employee', { inverse: null, async: false }),
  orderItem: DS.hasMany('i-i-s-shop-order-item', { inverse: 'order', async: false })
});

export let ValidationRules = {
  status: {
    descriptionKey: 'models.i-i-s-shop-order.validations.status.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  shipmentDate: {
    descriptionKey: 'models.i-i-s-shop-order.validations.shipmentDate.__caption__',
    validators: [
      validator('ds-error'),
      validator('date'),
    ],
  },
  paymentDate: {
    descriptionKey: 'models.i-i-s-shop-order.validations.paymentDate.__caption__',
    validators: [
      validator('ds-error'),
      validator('date'),
      validator('presence', {
        presence: true,
        disabled: computed('model.status', function() {

          let status = this.get('model.status');
          let deleteValidator = status !==OrderStatusEnum.Paid && status !==OrderStatusEnum.Canceled;
          return deleteValidator;
        })
      }),
       
    ],
  },
  totalSum: {
    descriptionKey: 'models.i-i-s-shop-order.validations.totalSum.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true }),
    ],
  },
  manager: {
    descriptionKey: 'models.i-i-s-shop-order.validations.manager.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  orderItem: {
    descriptionKey: 'models.i-i-s-shop-order.validations.orderItem.__caption__',
    validators: [
      validator('ds-error'),
      validator('has-many'),
    ],
  },
};

export let defineBaseModel = function (modelClass) {
  modelClass.reopenClass({
    _parentModelName: 'i-i-s-shop-document'
  });
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('OrderE', 'i-i-s-shop-order', {
    number: attr('??????????', { index: 0 }),
    status: attr('????????????', { index: 1 }),
    createDate: attr('???????? ????????????????????', { index: 2 }),
    manager: belongsTo('i-i-s-shop-employee', '????????????????', {
      lastName: attr('~', { index: 4, hidden: true }),
      middleName: attr('~', { index: 8, hidden: true }),
      firstName: attr('~', { index: 9, hidden: true })
    }, { index: 3, displayMemberPath: 'lastName' }),
    totalSum: attr('?????????? ????????????', { index: 5 }),
    paymentDate: attr('???????? ????????????', { index: 6 }),
    shipmentDate: attr('???????? ????????????????', { index: 7 }),
    orderItem: hasMany('i-i-s-shop-order-item', '???????????????????? ????????????(fixed)', {
      amount: attr('????????????????????', { index: 0 }),
      totalSum: attr('?????????? ???? ??????????????', { index: 2 }),
      priceWTaxes: attr('???????? ?? ??????????????', { index: 3 }),
      product: belongsTo('i-i-s-shop-product', '??????????', {
        productCode: attr('~', { index: 4, hidden: true }),
        name: attr('~', { index: 5, hidden: true })
      }, { index: 1, displayMemberPath: 'name' })
    })
  });

  modelClass.defineProjection('OrderL', 'i-i-s-shop-order', {
    number: attr('??????????', { index: 0 }),
    status: attr('????????????', { index: 1 }),
    createDate: attr('???????? ????????????????????', { index: 2 }),
    manager: belongsTo('i-i-s-shop-employee', '????????????????', {
      lastName: attr('????????????????', { index: 3 })
    }, { index: -1, hidden: true }),
    totalSum: attr('?????????????????? ????????????', { index: 4 }),
    paymentDate: attr('???????? ????????????', { index: 5 }),
    shipmentDate: attr('???????? ????????????????', { index: 6 }),
    orderItem: hasMany('i-i-s-shop-order-item', '', {
      amount: attr('~', { index: 0, hidden: true }),
      priceWTaxes: attr('~', { index: 1, hidden: true })
    })
  });
};
