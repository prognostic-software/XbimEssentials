// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.ActorResource;
using Xbim.Ifc2x3.DateTimeResource;
using Xbim.Ifc2x3.CostResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.SharedFacilitiesElements;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcInventory
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcInventory : IIfcGroup
	{
		IfcInventoryTypeEnum @InventoryType { get;  set; }
		IIfcActorSelect @Jurisdiction { get;  set; }
		IItemSet<IIfcPerson> @ResponsiblePersons { get; }
		IIfcCalendarDate @LastUpdateDate { get;  set; }
		IIfcCostValue @CurrentValue { get;  set; }
		IIfcCostValue @OriginalValue { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.SharedFacilitiesElements
{
	[ExpressType("IfcInventory", 768)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcInventory : IfcGroup, IInstantiableEntity, IIfcInventory, IContainsEntityReferences, IEquatable<@IfcInventory>
	{
		#region IIfcInventory explicit implementation
		IfcInventoryTypeEnum IIfcInventory.InventoryType { 
 
			get { return @InventoryType; } 
			set { InventoryType = value;}
		}	
		IIfcActorSelect IIfcInventory.Jurisdiction { 
 
 
			get { return @Jurisdiction; } 
			set { Jurisdiction = value as IfcActorSelect;}
		}	
		IItemSet<IIfcPerson> IIfcInventory.ResponsiblePersons { 
			get { return new Common.Collections.ProxyItemSet<IfcPerson, IIfcPerson>( @ResponsiblePersons); } 
		}	
		IIfcCalendarDate IIfcInventory.LastUpdateDate { 
 
 
			get { return @LastUpdateDate; } 
			set { LastUpdateDate = value as IfcCalendarDate;}
		}	
		IIfcCostValue IIfcInventory.CurrentValue { 
 
 
			get { return @CurrentValue; } 
			set { CurrentValue = value as IfcCostValue;}
		}	
		IIfcCostValue IIfcInventory.OriginalValue { 
 
 
			get { return @OriginalValue; } 
			set { OriginalValue = value as IfcCostValue;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcInventory(IModel model) : base(model) 		{ 
			_responsiblePersons = new ItemSet<IfcPerson>( this, 0,  8);
		}

		#region Explicit attribute fields
		private IfcInventoryTypeEnum _inventoryType;
		private IfcActorSelect _jurisdiction;
		private readonly ItemSet<IfcPerson> _responsiblePersons;
		private IfcCalendarDate _lastUpdateDate;
		private IfcCostValue _currentValue;
		private IfcCostValue _originalValue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 12)]
		public IfcInventoryTypeEnum @InventoryType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _inventoryType;
				((IPersistEntity)this).Activate(false);
				return _inventoryType;
			} 
			set
			{
				SetValue( v =>  _inventoryType = v, _inventoryType, value,  "InventoryType", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 13)]
		public IfcActorSelect @Jurisdiction 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _jurisdiction;
				((IPersistEntity)this).Activate(false);
				return _jurisdiction;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _jurisdiction = v, _jurisdiction, value,  "Jurisdiction", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 14)]
		public IItemSet<IfcPerson> @ResponsiblePersons 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _responsiblePersons;
				((IPersistEntity)this).Activate(false);
				return _responsiblePersons;
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 15)]
		public IfcCalendarDate @LastUpdateDate 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _lastUpdateDate;
				((IPersistEntity)this).Activate(false);
				return _lastUpdateDate;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _lastUpdateDate = v, _lastUpdateDate, value,  "LastUpdateDate", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 16)]
		public IfcCostValue @CurrentValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _currentValue;
				((IPersistEntity)this).Activate(false);
				return _currentValue;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _currentValue = v, _currentValue, value,  "CurrentValue", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 17)]
		public IfcCostValue @OriginalValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _originalValue;
				((IPersistEntity)this).Activate(false);
				return _originalValue;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _originalValue = v, _originalValue, value,  "OriginalValue", 11);
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
                    _inventoryType = (IfcInventoryTypeEnum) System.Enum.Parse(typeof (IfcInventoryTypeEnum), value.EnumVal, true);
					return;
				case 6: 
					_jurisdiction = (IfcActorSelect)(value.EntityVal);
					return;
				case 7: 
					_responsiblePersons.InternalAdd((IfcPerson)value.EntityVal);
					return;
				case 8: 
					_lastUpdateDate = (IfcCalendarDate)(value.EntityVal);
					return;
				case 9: 
					_currentValue = (IfcCostValue)(value.EntityVal);
					return;
				case 10: 
					_originalValue = (IfcCostValue)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcInventory other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcInventory
            var root = (@IfcInventory)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcInventory left, @IfcInventory right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcInventory left, @IfcInventory right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				if (@Jurisdiction != null)
					yield return @Jurisdiction;
				foreach(var entity in @ResponsiblePersons)
					yield return entity;
				if (@LastUpdateDate != null)
					yield return @LastUpdateDate;
				if (@CurrentValue != null)
					yield return @CurrentValue;
				if (@OriginalValue != null)
					yield return @OriginalValue;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}