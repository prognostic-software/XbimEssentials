// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.GeometricConstraintResource;
using Xbim.Ifc4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.ProductExtension;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelSpaceBoundary
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelSpaceBoundary : IIfcRelConnects
	{
		IIfcSpaceBoundarySelect @RelatingSpace { get;  set; }
		IIfcElement @RelatedBuildingElement { get;  set; }
		IIfcConnectionGeometry @ConnectionGeometry { get;  set; }
		IfcPhysicalOrVirtualEnum @PhysicalOrVirtualBoundary { get;  set; }
		IfcInternalOrExternalEnum @InternalOrExternalBoundary { get;  set; }
	
	}
}

namespace Xbim.Ifc4.ProductExtension
{
	[ExpressType("IfcRelSpaceBoundary", 15)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelSpaceBoundary : IfcRelConnects, IInstantiableEntity, IIfcRelSpaceBoundary, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelSpaceBoundary>
	{
		#region IIfcRelSpaceBoundary explicit implementation
		IIfcSpaceBoundarySelect IIfcRelSpaceBoundary.RelatingSpace { 
 
 
			get { return @RelatingSpace; } 
			set { RelatingSpace = value as IfcSpaceBoundarySelect;}
		}	
		IIfcElement IIfcRelSpaceBoundary.RelatedBuildingElement { 
 
 
			get { return @RelatedBuildingElement; } 
			set { RelatedBuildingElement = value as IfcElement;}
		}	
		IIfcConnectionGeometry IIfcRelSpaceBoundary.ConnectionGeometry { 
 
 
			get { return @ConnectionGeometry; } 
			set { ConnectionGeometry = value as IfcConnectionGeometry;}
		}	
		IfcPhysicalOrVirtualEnum IIfcRelSpaceBoundary.PhysicalOrVirtualBoundary { 
 
			get { return @PhysicalOrVirtualBoundary; } 
			set { PhysicalOrVirtualBoundary = value;}
		}	
		IfcInternalOrExternalEnum IIfcRelSpaceBoundary.InternalOrExternalBoundary { 
 
			get { return @InternalOrExternalBoundary; } 
			set { InternalOrExternalBoundary = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelSpaceBoundary(IModel model) : base(model) 		{ 
		}

		#region Explicit attribute fields
		private IfcSpaceBoundarySelect _relatingSpace;
		private IfcElement _relatedBuildingElement;
		private IfcConnectionGeometry _connectionGeometry;
		private IfcPhysicalOrVirtualEnum _physicalOrVirtualBoundary;
		private IfcInternalOrExternalEnum _internalOrExternalBoundary;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 5)]
		public IfcSpaceBoundarySelect @RelatingSpace 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingSpace;
				((IPersistEntity)this).Activate(false);
				return _relatingSpace;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingSpace = v, _relatingSpace, value,  "RelatingSpace", 5);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 6)]
		public IfcElement @RelatedBuildingElement 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedBuildingElement;
				((IPersistEntity)this).Activate(false);
				return _relatedBuildingElement;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatedBuildingElement = v, _relatedBuildingElement, value,  "RelatedBuildingElement", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 7)]
		public IfcConnectionGeometry @ConnectionGeometry 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _connectionGeometry;
				((IPersistEntity)this).Activate(false);
				return _connectionGeometry;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _connectionGeometry = v, _connectionGeometry, value,  "ConnectionGeometry", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 8)]
		public IfcPhysicalOrVirtualEnum @PhysicalOrVirtualBoundary 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _physicalOrVirtualBoundary;
				((IPersistEntity)this).Activate(false);
				return _physicalOrVirtualBoundary;
			} 
			set
			{
				SetValue( v =>  _physicalOrVirtualBoundary = v, _physicalOrVirtualBoundary, value,  "PhysicalOrVirtualBoundary", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 9)]
		public IfcInternalOrExternalEnum @InternalOrExternalBoundary 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _internalOrExternalBoundary;
				((IPersistEntity)this).Activate(false);
				return _internalOrExternalBoundary;
			} 
			set
			{
				SetValue( v =>  _internalOrExternalBoundary = v, _internalOrExternalBoundary, value,  "InternalOrExternalBoundary", 9);
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
					_relatingSpace = (IfcSpaceBoundarySelect)(value.EntityVal);
					return;
				case 5: 
					_relatedBuildingElement = (IfcElement)(value.EntityVal);
					return;
				case 6: 
					_connectionGeometry = (IfcConnectionGeometry)(value.EntityVal);
					return;
				case 7: 
                    _physicalOrVirtualBoundary = (IfcPhysicalOrVirtualEnum) System.Enum.Parse(typeof (IfcPhysicalOrVirtualEnum), value.EnumVal, true);
					return;
				case 8: 
                    _internalOrExternalBoundary = (IfcInternalOrExternalEnum) System.Enum.Parse(typeof (IfcInternalOrExternalEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelSpaceBoundary other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelSpaceBoundary
            var root = (@IfcRelSpaceBoundary)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelSpaceBoundary left, @IfcRelSpaceBoundary right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcRelSpaceBoundary left, @IfcRelSpaceBoundary right)
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
				if (@RelatingSpace != null)
					yield return @RelatingSpace;
				if (@RelatedBuildingElement != null)
					yield return @RelatedBuildingElement;
				if (@ConnectionGeometry != null)
					yield return @ConnectionGeometry;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@RelatingSpace != null)
					yield return @RelatingSpace;
				if (@RelatedBuildingElement != null)
					yield return @RelatedBuildingElement;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}