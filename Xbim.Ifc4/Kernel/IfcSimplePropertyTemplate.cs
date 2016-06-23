// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.PropertyResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Kernel;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSimplePropertyTemplate
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSimplePropertyTemplate : IIfcPropertyTemplate
	{
		IfcSimplePropertyTemplateTypeEnum? @TemplateType { get;  set; }
		IfcLabel? @PrimaryMeasureType { get;  set; }
		IfcLabel? @SecondaryMeasureType { get;  set; }
		IIfcPropertyEnumeration @Enumerators { get;  set; }
		IIfcUnit @PrimaryUnit { get;  set; }
		IIfcUnit @SecondaryUnit { get;  set; }
		IfcLabel? @Expression { get;  set; }
		IfcStateEnum? @AccessState { get;  set; }
	
	}
}

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IfcSimplePropertyTemplate", 1267)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSimplePropertyTemplate : IfcPropertyTemplate, IInstantiableEntity, IIfcSimplePropertyTemplate, IContainsEntityReferences, IEquatable<@IfcSimplePropertyTemplate>
	{
		#region IIfcSimplePropertyTemplate explicit implementation
		IfcSimplePropertyTemplateTypeEnum? IIfcSimplePropertyTemplate.TemplateType { 
 
			get { return @TemplateType; } 
			set { TemplateType = value;}
		}	
		IfcLabel? IIfcSimplePropertyTemplate.PrimaryMeasureType { 
 
			get { return @PrimaryMeasureType; } 
			set { PrimaryMeasureType = value;}
		}	
		IfcLabel? IIfcSimplePropertyTemplate.SecondaryMeasureType { 
 
			get { return @SecondaryMeasureType; } 
			set { SecondaryMeasureType = value;}
		}	
		IIfcPropertyEnumeration IIfcSimplePropertyTemplate.Enumerators { 
 
 
			get { return @Enumerators; } 
			set { Enumerators = value as IfcPropertyEnumeration;}
		}	
		IIfcUnit IIfcSimplePropertyTemplate.PrimaryUnit { 
 
 
			get { return @PrimaryUnit; } 
			set { PrimaryUnit = value as IfcUnit;}
		}	
		IIfcUnit IIfcSimplePropertyTemplate.SecondaryUnit { 
 
 
			get { return @SecondaryUnit; } 
			set { SecondaryUnit = value as IfcUnit;}
		}	
		IfcLabel? IIfcSimplePropertyTemplate.Expression { 
 
			get { return @Expression; } 
			set { Expression = value;}
		}	
		IfcStateEnum? IIfcSimplePropertyTemplate.AccessState { 
 
			get { return @AccessState; } 
			set { AccessState = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSimplePropertyTemplate(IModel model) : base(model) 		{ 
		}

		#region Explicit attribute fields
		private IfcSimplePropertyTemplateTypeEnum? _templateType;
		private IfcLabel? _primaryMeasureType;
		private IfcLabel? _secondaryMeasureType;
		private IfcPropertyEnumeration _enumerators;
		private IfcUnit _primaryUnit;
		private IfcUnit _secondaryUnit;
		private IfcLabel? _expression;
		private IfcStateEnum? _accessState;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 9)]
		public IfcSimplePropertyTemplateTypeEnum? @TemplateType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _templateType;
				((IPersistEntity)this).Activate(false);
				return _templateType;
			} 
			set
			{
				SetValue( v =>  _templateType = v, _templateType, value,  "TemplateType", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 10)]
		public IfcLabel? @PrimaryMeasureType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _primaryMeasureType;
				((IPersistEntity)this).Activate(false);
				return _primaryMeasureType;
			} 
			set
			{
				SetValue( v =>  _primaryMeasureType = v, _primaryMeasureType, value,  "PrimaryMeasureType", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 11)]
		public IfcLabel? @SecondaryMeasureType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _secondaryMeasureType;
				((IPersistEntity)this).Activate(false);
				return _secondaryMeasureType;
			} 
			set
			{
				SetValue( v =>  _secondaryMeasureType = v, _secondaryMeasureType, value,  "SecondaryMeasureType", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 12)]
		public IfcPropertyEnumeration @Enumerators 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _enumerators;
				((IPersistEntity)this).Activate(false);
				return _enumerators;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _enumerators = v, _enumerators, value,  "Enumerators", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 13)]
		public IfcUnit @PrimaryUnit 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _primaryUnit;
				((IPersistEntity)this).Activate(false);
				return _primaryUnit;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _primaryUnit = v, _primaryUnit, value,  "PrimaryUnit", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 14)]
		public IfcUnit @SecondaryUnit 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _secondaryUnit;
				((IPersistEntity)this).Activate(false);
				return _secondaryUnit;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _secondaryUnit = v, _secondaryUnit, value,  "SecondaryUnit", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 15)]
		public IfcLabel? @Expression 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _expression;
				((IPersistEntity)this).Activate(false);
				return _expression;
			} 
			set
			{
				SetValue( v =>  _expression = v, _expression, value,  "Expression", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 16)]
		public IfcStateEnum? @AccessState 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _accessState;
				((IPersistEntity)this).Activate(false);
				return _accessState;
			} 
			set
			{
				SetValue( v =>  _accessState = v, _accessState, value,  "AccessState", 12);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
                    _templateType = (IfcSimplePropertyTemplateTypeEnum) System.Enum.Parse(typeof (IfcSimplePropertyTemplateTypeEnum), value.EnumVal, true);
					return;
				case 5: 
					_primaryMeasureType = value.StringVal;
					return;
				case 6: 
					_secondaryMeasureType = value.StringVal;
					return;
				case 7: 
					_enumerators = (IfcPropertyEnumeration)(value.EntityVal);
					return;
				case 8: 
					_primaryUnit = (IfcUnit)(value.EntityVal);
					return;
				case 9: 
					_secondaryUnit = (IfcUnit)(value.EntityVal);
					return;
				case 10: 
					_expression = value.StringVal;
					return;
				case 11: 
                    _accessState = (IfcStateEnum) System.Enum.Parse(typeof (IfcStateEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSimplePropertyTemplate other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcSimplePropertyTemplate
            var root = (@IfcSimplePropertyTemplate)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcSimplePropertyTemplate left, @IfcSimplePropertyTemplate right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcSimplePropertyTemplate left, @IfcSimplePropertyTemplate right)
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
				if (@Enumerators != null)
					yield return @Enumerators;
				if (@PrimaryUnit != null)
					yield return @PrimaryUnit;
				if (@SecondaryUnit != null)
					yield return @SecondaryUnit;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}