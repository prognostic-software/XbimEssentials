// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.PropertyResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPropertyTableValue
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPropertyTableValue : IIfcSimpleProperty
	{
		IItemSet<IIfcValue> @DefiningValues { get; }
		IItemSet<IIfcValue> @DefinedValues { get; }
		IfcText? @Expression { get;  set; }
		IIfcUnit @DefiningUnit { get;  set; }
		IIfcUnit @DefinedUnit { get;  set; }
		IfcCurveInterpolationEnum? @CurveInterpolation { get;  set; }
	
	}
}

namespace Xbim.Ifc4.PropertyResource
{
	[ExpressType("IfcPropertyTableValue", 557)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPropertyTableValue : IfcSimpleProperty, IInstantiableEntity, IIfcPropertyTableValue, IContainsEntityReferences, IEquatable<@IfcPropertyTableValue>
	{
		#region IIfcPropertyTableValue explicit implementation
		IItemSet<IIfcValue> IIfcPropertyTableValue.DefiningValues { 
			get { return new Common.Collections.ProxyItemSet<IfcValue, IIfcValue>( @DefiningValues); } 
		}	
		IItemSet<IIfcValue> IIfcPropertyTableValue.DefinedValues { 
			get { return new Common.Collections.ProxyItemSet<IfcValue, IIfcValue>( @DefinedValues); } 
		}	
		IfcText? IIfcPropertyTableValue.Expression { 
 
			get { return @Expression; } 
			set { Expression = value;}
		}	
		IIfcUnit IIfcPropertyTableValue.DefiningUnit { 
 
 
			get { return @DefiningUnit; } 
			set { DefiningUnit = value as IfcUnit;}
		}	
		IIfcUnit IIfcPropertyTableValue.DefinedUnit { 
 
 
			get { return @DefinedUnit; } 
			set { DefinedUnit = value as IfcUnit;}
		}	
		IfcCurveInterpolationEnum? IIfcPropertyTableValue.CurveInterpolation { 
 
			get { return @CurveInterpolation; } 
			set { CurveInterpolation = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertyTableValue(IModel model) : base(model) 		{ 
			_definingValues = new OptionalItemSet<IfcValue>( this, 0,  3);
			_definedValues = new OptionalItemSet<IfcValue>( this, 0,  4);
		}

		#region Explicit attribute fields
		private readonly OptionalItemSet<IfcValue> _definingValues;
		private readonly OptionalItemSet<IfcValue> _definedValues;
		private IfcText? _expression;
		private IfcUnit _definingUnit;
		private IfcUnit _definedUnit;
		private IfcCurveInterpolationEnum? _curveInterpolation;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.ListUnique, EntityAttributeType.Class, 1, -1, 10)]
		public IOptionalItemSet<IfcValue> @DefiningValues 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _definingValues;
				((IPersistEntity)this).Activate(false);
				return _definingValues;
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1, 11)]
		public IOptionalItemSet<IfcValue> @DefinedValues 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _definedValues;
				((IPersistEntity)this).Activate(false);
				return _definedValues;
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 12)]
		public IfcText? @Expression 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _expression;
				((IPersistEntity)this).Activate(false);
				return _expression;
			} 
			set
			{
				SetValue( v =>  _expression = v, _expression, value,  "Expression", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 13)]
		public IfcUnit @DefiningUnit 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _definingUnit;
				((IPersistEntity)this).Activate(false);
				return _definingUnit;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _definingUnit = v, _definingUnit, value,  "DefiningUnit", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 14)]
		public IfcUnit @DefinedUnit 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _definedUnit;
				((IPersistEntity)this).Activate(false);
				return _definedUnit;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _definedUnit = v, _definedUnit, value,  "DefinedUnit", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 15)]
		public IfcCurveInterpolationEnum? @CurveInterpolation 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _curveInterpolation;
				((IPersistEntity)this).Activate(false);
				return _curveInterpolation;
			} 
			set
			{
				SetValue( v =>  _curveInterpolation = v, _curveInterpolation, value,  "CurveInterpolation", 8);
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
					_definingValues.InternalAdd((IfcValue)value.EntityVal);
					return;
				case 3: 
					_definedValues.InternalAdd((IfcValue)value.EntityVal);
					return;
				case 4: 
					_expression = value.StringVal;
					return;
				case 5: 
					_definingUnit = (IfcUnit)(value.EntityVal);
					return;
				case 6: 
					_definedUnit = (IfcUnit)(value.EntityVal);
					return;
				case 7: 
                    _curveInterpolation = (IfcCurveInterpolationEnum) System.Enum.Parse(typeof (IfcCurveInterpolationEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPropertyTableValue other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcPropertyTableValue
            var root = (@IfcPropertyTableValue)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcPropertyTableValue left, @IfcPropertyTableValue right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcPropertyTableValue left, @IfcPropertyTableValue right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@DefiningUnit != null)
					yield return @DefiningUnit;
				if (@DefinedUnit != null)
					yield return @DefinedUnit;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}