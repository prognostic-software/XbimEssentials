// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.ActorResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ProductExtension;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSite
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSite : IIfcSpatialStructureElement
	{
		IfcCompoundPlaneAngleMeasure? @RefLatitude { get;  set; }
		IfcCompoundPlaneAngleMeasure? @RefLongitude { get;  set; }
		IfcLengthMeasure? @RefElevation { get;  set; }
		IfcLabel? @LandTitleNumber { get;  set; }
		IIfcPostalAddress @SiteAddress { get;  set; }
	
	}
}

namespace Xbim.Ifc4.ProductExtension
{
	[ExpressType("IfcSite", 349)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSite : IfcSpatialStructureElement, IInstantiableEntity, IIfcSite, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcSite>
	{
		#region IIfcSite explicit implementation
		IfcCompoundPlaneAngleMeasure? IIfcSite.RefLatitude { 
 
			get { return @RefLatitude; } 
			set { RefLatitude = value;}
		}	
		IfcCompoundPlaneAngleMeasure? IIfcSite.RefLongitude { 
 
			get { return @RefLongitude; } 
			set { RefLongitude = value;}
		}	
		IfcLengthMeasure? IIfcSite.RefElevation { 
 
			get { return @RefElevation; } 
			set { RefElevation = value;}
		}	
		IfcLabel? IIfcSite.LandTitleNumber { 
 
			get { return @LandTitleNumber; } 
			set { LandTitleNumber = value;}
		}	
		IIfcPostalAddress IIfcSite.SiteAddress { 
 
 
			get { return @SiteAddress; } 
			set { SiteAddress = value as IfcPostalAddress;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSite(IModel model) : base(model) 		{ 
		}

		#region Explicit attribute fields
		private IfcCompoundPlaneAngleMeasure? _refLatitude;
		private IfcCompoundPlaneAngleMeasure? _refLongitude;
		private IfcLengthMeasure? _refElevation;
		private IfcLabel? _landTitleNumber;
		private IfcPostalAddress _siteAddress;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 25)]
		public IfcCompoundPlaneAngleMeasure? @RefLatitude 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _refLatitude;
				((IPersistEntity)this).Activate(false);
				return _refLatitude;
			} 
			set
			{
				SetValue( v =>  _refLatitude = v, _refLatitude, value,  "RefLatitude", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 26)]
		public IfcCompoundPlaneAngleMeasure? @RefLongitude 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _refLongitude;
				((IPersistEntity)this).Activate(false);
				return _refLongitude;
			} 
			set
			{
				SetValue( v =>  _refLongitude = v, _refLongitude, value,  "RefLongitude", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 27)]
		public IfcLengthMeasure? @RefElevation 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _refElevation;
				((IPersistEntity)this).Activate(false);
				return _refElevation;
			} 
			set
			{
				SetValue( v =>  _refElevation = v, _refElevation, value,  "RefElevation", 12);
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 28)]
		public IfcLabel? @LandTitleNumber 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _landTitleNumber;
				((IPersistEntity)this).Activate(false);
				return _landTitleNumber;
			} 
			set
			{
				SetValue( v =>  _landTitleNumber = v, _landTitleNumber, value,  "LandTitleNumber", 13);
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 29)]
		public IfcPostalAddress @SiteAddress 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _siteAddress;
				((IPersistEntity)this).Activate(false);
				return _siteAddress;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _siteAddress = v, _siteAddress, value,  "SiteAddress", 14);
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
				case 5: 
				case 6: 
				case 7: 
				case 8: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 9: 
					if (!_refLatitude.HasValue) _refLatitude = new IfcCompoundPlaneAngleMeasure();
			        var refLatitude = _refLatitude.Value;
					IfcCompoundPlaneAngleMeasure.Add(ref refLatitude, value.IntegerVal);
					_refLatitude = refLatitude;
					return;
				case 10: 
					if (!_refLongitude.HasValue) _refLongitude = new IfcCompoundPlaneAngleMeasure();
			        var refLongitude = _refLongitude.Value;
					IfcCompoundPlaneAngleMeasure.Add(ref refLongitude, value.IntegerVal);
					_refLongitude = refLongitude;
					return;
				case 11: 
					_refElevation = value.RealVal;
					return;
				case 12: 
					_landTitleNumber = value.StringVal;
					return;
				case 13: 
					_siteAddress = (IfcPostalAddress)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSite other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcSite
            var root = (@IfcSite)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcSite left, @IfcSite right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcSite left, @IfcSite right)
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
				if (@ObjectPlacement != null)
					yield return @ObjectPlacement;
				if (@Representation != null)
					yield return @Representation;
				if (@SiteAddress != null)
					yield return @SiteAddress;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@ObjectPlacement != null)
					yield return @ObjectPlacement;
				if (@Representation != null)
					yield return @Representation;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}