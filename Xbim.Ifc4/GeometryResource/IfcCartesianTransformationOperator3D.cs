// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

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
    /// Readonly interface for IfcCartesianTransformationOperator3D
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCartesianTransformationOperator3D : IIfcCartesianTransformationOperator
	{
		IIfcDirection @Axis3 { get;  set; }
		List<Common.Geometry.XbimVector3D> @U  { get ; }
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IfcCartesianTransformationOperator3D", 337)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCartesianTransformationOperator3D : IfcCartesianTransformationOperator, IInstantiableEntity, IIfcCartesianTransformationOperator3D, IContainsEntityReferences, IEquatable<@IfcCartesianTransformationOperator3D>
	{
		#region IIfcCartesianTransformationOperator3D explicit implementation
		IIfcDirection IIfcCartesianTransformationOperator3D.Axis3 { 
 
 
			get { return @Axis3; } 
			set { Axis3 = value as IfcDirection;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCartesianTransformationOperator3D(IModel model) : base(model) 		{ 
		}

		#region Explicit attribute fields
		private IfcDirection _axis3;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 7)]
		public IfcDirection @Axis3 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _axis3;
				((IPersistEntity)this).Activate(false);
				return _axis3;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _axis3 = v, _axis3, value,  "Axis3", 5);
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.List, EntityAttributeType.Class, 3, 3, 0)]
		public List<Common.Geometry.XbimVector3D> @U 
		{
			get 
			{
				//## Getter for U
				//TODO: Implement getter for derived attribute U
				throw new System.NotImplementedException();
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
				case 1: 
				case 2: 
				case 3: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_axis3 = (IfcDirection)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCartesianTransformationOperator3D other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcCartesianTransformationOperator3D
            var root = (@IfcCartesianTransformationOperator3D)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcCartesianTransformationOperator3D left, @IfcCartesianTransformationOperator3D right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcCartesianTransformationOperator3D left, @IfcCartesianTransformationOperator3D right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Axis1 != null)
					yield return @Axis1;
				if (@Axis2 != null)
					yield return @Axis2;
				if (@LocalOrigin != null)
					yield return @LocalOrigin;
				if (@Axis3 != null)
					yield return @Axis3;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}