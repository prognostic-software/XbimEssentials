// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PresentationAppearanceResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcVector
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcVector : IIfcGeometricRepresentationItem, IfcHatchLineDistanceSelect, IfcVectorOrDirection
	{
		IIfcDirection @Orientation { get;  set; }
		IfcLengthMeasure @Magnitude { get;  set; }
		IfcDimensionCount @Dim  { get ; }
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IfcVector", 652)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcVector : IfcGeometricRepresentationItem, IInstantiableEntity, IIfcVector, IContainsEntityReferences, IEquatable<@IfcVector>
	{
		#region IIfcVector explicit implementation
		IIfcDirection IIfcVector.Orientation { 
 
 
			get { return @Orientation; } 
			set { Orientation = value as IfcDirection;}
		}	
		IfcLengthMeasure IIfcVector.Magnitude { 
 
			get { return @Magnitude; } 
			set { Magnitude = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcVector(IModel model) : base(model) 		{ 
		}

		#region Explicit attribute fields
		private IfcDirection _orientation;
		private IfcLengthMeasure _magnitude;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcDirection @Orientation 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _orientation;
				((IPersistEntity)this).Activate(false);
				return _orientation;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _orientation = v, _orientation, value,  "Orientation", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcLengthMeasure @Magnitude 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _magnitude;
				((IPersistEntity)this).Activate(false);
				return _magnitude;
			} 
			set
			{
				SetValue( v =>  _magnitude = v, _magnitude, value,  "Magnitude", 2);
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 0)]
		public IfcDimensionCount @Dim 
		{
			get 
			{
				//## Getter for Dim
			    return Orientation.Dim;
			    //##
			}
		}

		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_orientation = (IfcDirection)(value.EntityVal);
					return;
				case 1: 
					_magnitude = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcVector other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcVector
            var root = (@IfcVector)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcVector left, @IfcVector right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcVector left, @IfcVector right)
        {
            return !(left == right);
        }

        public static bool operator ==(@IfcVector left, IfcHatchLineDistanceSelect right)
		{
			return left == right as @IfcVector;
		}

		public static bool operator !=(@IfcVector left, IfcHatchLineDistanceSelect right)
		{
			return !(left == right);
		}

        public static bool operator ==(@IfcVector left, IfcVectorOrDirection right)
		{
			return left == right as @IfcVector;
		}

		public static bool operator !=(@IfcVector left, IfcVectorOrDirection right)
		{
			return !(left == right);
		}

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Orientation != null)
					yield return @Orientation;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}