// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometricModelResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCsgPrimitive3D
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCsgPrimitive3D : IIfcGeometricRepresentationItem, IfcBooleanOperand, IfcCsgSelect
	{
		IIfcAxis2Placement3D @Position { get;  set; }
	
	}
}

namespace Xbim.Ifc4.GeometricModelResource
{
	[ExpressType("IfcCsgPrimitive3D", 714)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcCsgPrimitive3D : IfcGeometricRepresentationItem, IIfcCsgPrimitive3D, IEquatable<@IfcCsgPrimitive3D>
	{
		#region IIfcCsgPrimitive3D explicit implementation
		IIfcAxis2Placement3D IIfcCsgPrimitive3D.Position { 
 
 
			get { return @Position; } 
			set { Position = value as IfcAxis2Placement3D;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCsgPrimitive3D(IModel model) : base(model) 		{ 
		}

		#region Explicit attribute fields
		private IfcAxis2Placement3D _position;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcAxis2Placement3D @Position 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _position;
				((IPersistEntity)this).Activate(false);
				return _position;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _position = v, _position, value,  "Position", 1);
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
			    return 3;
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
					_position = (IfcAxis2Placement3D)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCsgPrimitive3D other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcCsgPrimitive3D
            var root = (@IfcCsgPrimitive3D)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcCsgPrimitive3D left, @IfcCsgPrimitive3D right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcCsgPrimitive3D left, @IfcCsgPrimitive3D right)
        {
            return !(left == right);
        }

        public static bool operator ==(@IfcCsgPrimitive3D left, IfcBooleanOperand right)
		{
			return left == right as @IfcCsgPrimitive3D;
		}

		public static bool operator !=(@IfcCsgPrimitive3D left, IfcBooleanOperand right)
		{
			return !(left == right);
		}

        public static bool operator ==(@IfcCsgPrimitive3D left, IfcCsgSelect right)
		{
			return left == right as @IfcCsgPrimitive3D;
		}

		public static bool operator !=(@IfcCsgPrimitive3D left, IfcCsgSelect right)
		{
			return !(left == right);
		}

        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}