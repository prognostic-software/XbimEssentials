// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.DateTimeResource;
using Xbim.Ifc2x3.ExternalReferenceResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.CostResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCurrencyRelationship
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCurrencyRelationship : IPersistEntity
	{
		IIfcMonetaryUnit @RelatingMonetaryUnit { get;  set; }
		IIfcMonetaryUnit @RelatedMonetaryUnit { get;  set; }
		IfcPositiveRatioMeasure @ExchangeRate { get;  set; }
		IIfcDateAndTime @RateDateTime { get;  set; }
		IIfcLibraryInformation @RateSource { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.CostResource
{
	[ExpressType("IfcCurrencyRelationship", 195)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCurrencyRelationship : INotifyPropertyChanged, IInstantiableEntity, IIfcCurrencyRelationship, IContainsEntityReferences, IEquatable<@IfcCurrencyRelationship>
	{
		#region IIfcCurrencyRelationship explicit implementation
		IIfcMonetaryUnit IIfcCurrencyRelationship.RelatingMonetaryUnit { 
 
 
			get { return @RelatingMonetaryUnit; } 
			set { RelatingMonetaryUnit = value as IfcMonetaryUnit;}
		}	
		IIfcMonetaryUnit IIfcCurrencyRelationship.RelatedMonetaryUnit { 
 
 
			get { return @RelatedMonetaryUnit; } 
			set { RelatedMonetaryUnit = value as IfcMonetaryUnit;}
		}	
		IfcPositiveRatioMeasure IIfcCurrencyRelationship.ExchangeRate { 
 
			get { return @ExchangeRate; } 
			set { ExchangeRate = value;}
		}	
		IIfcDateAndTime IIfcCurrencyRelationship.RateDateTime { 
 
 
			get { return @RateDateTime; } 
			set { RateDateTime = value as IfcDateAndTime;}
		}	
		IIfcLibraryInformation IIfcCurrencyRelationship.RateSource { 
 
 
			get { return @RateSource; } 
			set { RateSource = value as IfcLibraryInformation;}
		}	
		 
		#endregion

		#region Implementation of IPersistEntity

		public int EntityLabel {get; internal set;}
		
		public IModel Model { get; internal set; }

		/// <summary>
        /// This property is deprecated and likely to be removed. Use just 'Model' instead.
        /// </summary>
		[Obsolete("This property is deprecated and likely to be removed. Use just 'Model' instead.")]
        public IModel ModelOf { get { return Model; } }
		
	    internal ActivationStatus ActivationStatus = ActivationStatus.NotActivated;

	    ActivationStatus IPersistEntity.ActivationStatus { get { return ActivationStatus; } }
		
		void IPersistEntity.Activate(bool write)
		{
			switch (ActivationStatus)
		    {
		        case ActivationStatus.ActivatedReadWrite:
		            return;
		        case ActivationStatus.NotActivated:
		            lock (this)
		            {
                        //check again in the lock
		                if (ActivationStatus == ActivationStatus.NotActivated)
		                {
		                    if (Model.Activate(this, write))
		                    {
		                        ActivationStatus = write
		                            ? ActivationStatus.ActivatedReadWrite
		                            : ActivationStatus.ActivatedRead;
		                    }
		                }
		            }
		            break;
		        case ActivationStatus.ActivatedRead:
		            if (!write) return;
		            if (Model.Activate(this, true))
                        ActivationStatus = ActivationStatus.ActivatedReadWrite;
		            break;
		        default:
		            throw new ArgumentOutOfRangeException();
		    }
		}

		void IPersistEntity.Activate (Action activation)
		{
			if (ActivationStatus != ActivationStatus.NotActivated) return; //activation can only happen once in a lifetime of the object
			
			activation();
			ActivationStatus = ActivationStatus.ActivatedRead;
		}

		ExpressType IPersistEntity.ExpressType { get { return Model.Metadata.ExpressType(this);  } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCurrencyRelationship(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcMonetaryUnit _relatingMonetaryUnit;
		private IfcMonetaryUnit _relatedMonetaryUnit;
		private IfcPositiveRatioMeasure _exchangeRate;
		private IfcDateAndTime _rateDateTime;
		private IfcLibraryInformation _rateSource;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 1)]
		public IfcMonetaryUnit @RelatingMonetaryUnit 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingMonetaryUnit;
				((IPersistEntity)this).Activate(false);
				return _relatingMonetaryUnit;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingMonetaryUnit = v, _relatingMonetaryUnit, value,  "RelatingMonetaryUnit", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 2)]
		public IfcMonetaryUnit @RelatedMonetaryUnit 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedMonetaryUnit;
				((IPersistEntity)this).Activate(false);
				return _relatedMonetaryUnit;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatedMonetaryUnit = v, _relatedMonetaryUnit, value,  "RelatedMonetaryUnit", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcPositiveRatioMeasure @ExchangeRate 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _exchangeRate;
				((IPersistEntity)this).Activate(false);
				return _exchangeRate;
			} 
			set
			{
				SetValue( v =>  _exchangeRate = v, _exchangeRate, value,  "ExchangeRate", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 4)]
		public IfcDateAndTime @RateDateTime 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _rateDateTime;
				((IPersistEntity)this).Activate(false);
				return _rateDateTime;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _rateDateTime = v, _rateDateTime, value,  "RateDateTime", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 5)]
		public IfcLibraryInformation @RateSource 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _rateSource;
				((IPersistEntity)this).Activate(false);
				return _rateSource;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _rateSource = v, _rateSource, value,  "RateSource", 5);
			} 
		}	
		#endregion




		#region INotifyPropertyChanged implementation
		 
		public event PropertyChangedEventHandler PropertyChanged;

		protected void NotifyPropertyChanged( string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

		#endregion

		#region Transactional property setting

		protected void SetValue<TProperty>(Action<TProperty> setter, TProperty oldValue, TProperty newValue, string notifyPropertyName, byte propertyOrder)
		{
			//activate for write if it is not activated yet
			if (ActivationStatus != ActivationStatus.ActivatedReadWrite)
				((IPersistEntity)this).Activate(true);

			//just set the value if the model is marked as non-transactional
			if (!Model.IsTransactional)
			{
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
				return;
			}

			//check there is a transaction
			var txn = Model.CurrentTransaction;
			if (txn == null) throw new Exception("Operation out of transaction.");

			Action doAction = () => {
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
			};
			Action undoAction = () => {
				setter(oldValue);
				NotifyPropertyChanged(notifyPropertyName);
			};
			doAction();

			//do action and THAN add to transaction so that it gets the object in new state
			txn.AddReversibleAction(doAction, undoAction, this, ChangeType.Modified, propertyOrder);
		}

		#endregion

		#region IPersist implementation
		public virtual void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_relatingMonetaryUnit = (IfcMonetaryUnit)(value.EntityVal);
					return;
				case 1: 
					_relatedMonetaryUnit = (IfcMonetaryUnit)(value.EntityVal);
					return;
				case 2: 
					_exchangeRate = value.RealVal;
					return;
				case 3: 
					_rateDateTime = (IfcDateAndTime)(value.EntityVal);
					return;
				case 4: 
					_rateSource = (IfcLibraryInformation)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCurrencyRelationship other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcCurrencyRelationship
            var root = (@IfcCurrencyRelationship)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcCurrencyRelationship left, @IfcCurrencyRelationship right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcCurrencyRelationship left, @IfcCurrencyRelationship right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@RelatingMonetaryUnit != null)
					yield return @RelatingMonetaryUnit;
				if (@RelatedMonetaryUnit != null)
					yield return @RelatedMonetaryUnit;
				if (@RateDateTime != null)
					yield return @RateDateTime;
				if (@RateSource != null)
					yield return @RateSource;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}