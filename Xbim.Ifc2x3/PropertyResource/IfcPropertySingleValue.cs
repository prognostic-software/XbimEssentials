// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PropertyResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPropertySingleValue
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPropertySingleValue : IIfcSimpleProperty
	{
		IIfcValue @NominalValue { get;  set; }
		IIfcUnit @Unit { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.PropertyResource
{
	[ExpressType("IfcPropertySingleValue", 628)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPropertySingleValue : IfcSimpleProperty, IInstantiableEntity, IIfcPropertySingleValue, IContainsEntityReferences, IEquatable<@IfcPropertySingleValue>
	{
		#region IIfcPropertySingleValue explicit implementation
		IIfcValue IIfcPropertySingleValue.NominalValue { 
 
 
			get { return @NominalValue; } 
			set { NominalValue = value as IfcValue;}
		}	
		IIfcUnit IIfcPropertySingleValue.Unit { 
 
 
			get { return @Unit; } 
			set { Unit = value as IfcUnit;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertySingleValue(IModel model) : base(model) 		{ 
		}

		#region Explicit attribute fields
		private IfcValue _nominalValue;
		private IfcUnit _unit;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 6)]
		public IfcValue @NominalValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _nominalValue;
				((IPersistEntity)this).Activate(false);
				return _nominalValue;
			} 
			set
			{
				SetValue( v =>  _nominalValue = v, _nominalValue, value,  "NominalValue", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 7)]
		public IfcUnit @Unit 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _unit;
				((IPersistEntity)this).Activate(false);
				return _unit;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _unit = v, _unit, value,  "Unit", 4);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_nominalValue = (IfcValue)(value.EntityVal);
					return;
				case 3: 
					_unit = (IfcUnit)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPropertySingleValue other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcPropertySingleValue
            var root = (@IfcPropertySingleValue)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcPropertySingleValue left, @IfcPropertySingleValue right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcPropertySingleValue left, @IfcPropertySingleValue right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Unit != null)
					yield return @Unit;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}