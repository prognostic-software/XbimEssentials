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
using Xbim.Ifc2x3.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRectangularTrimmedSurface
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRectangularTrimmedSurface : IIfcBoundedSurface
	{
		IIfcSurface @BasisSurface { get;  set; }
		IfcParameterValue @U1 { get;  set; }
		IfcParameterValue @V1 { get;  set; }
		IfcParameterValue @U2 { get;  set; }
		IfcParameterValue @V2 { get;  set; }
		bool @Usense { get;  set; }
		bool @Vsense { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.GeometryResource
{
	[ExpressType("IfcRectangularTrimmedSurface", 653)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRectangularTrimmedSurface : IfcBoundedSurface, IInstantiableEntity, IIfcRectangularTrimmedSurface, IContainsEntityReferences, IEquatable<@IfcRectangularTrimmedSurface>
	{
		#region IIfcRectangularTrimmedSurface explicit implementation
		IIfcSurface IIfcRectangularTrimmedSurface.BasisSurface { 
 
 
			get { return @BasisSurface; } 
			set { BasisSurface = value as IfcSurface;}
		}	
		IfcParameterValue IIfcRectangularTrimmedSurface.U1 { 
 
			get { return @U1; } 
			set { U1 = value;}
		}	
		IfcParameterValue IIfcRectangularTrimmedSurface.V1 { 
 
			get { return @V1; } 
			set { V1 = value;}
		}	
		IfcParameterValue IIfcRectangularTrimmedSurface.U2 { 
 
			get { return @U2; } 
			set { U2 = value;}
		}	
		IfcParameterValue IIfcRectangularTrimmedSurface.V2 { 
 
			get { return @V2; } 
			set { V2 = value;}
		}	
		bool IIfcRectangularTrimmedSurface.Usense { 
 
			get { return @Usense; } 
			set { Usense = value;}
		}	
		bool IIfcRectangularTrimmedSurface.Vsense { 
 
			get { return @Vsense; } 
			set { Vsense = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRectangularTrimmedSurface(IModel model) : base(model) 		{ 
		}

		#region Explicit attribute fields
		private IfcSurface _basisSurface;
		private IfcParameterValue _u1;
		private IfcParameterValue _v1;
		private IfcParameterValue _u2;
		private IfcParameterValue _v2;
		private bool _usense;
		private bool _vsense;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcSurface @BasisSurface 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _basisSurface;
				((IPersistEntity)this).Activate(false);
				return _basisSurface;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _basisSurface = v, _basisSurface, value,  "BasisSurface", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcParameterValue @U1 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _u1;
				((IPersistEntity)this).Activate(false);
				return _u1;
			} 
			set
			{
				SetValue( v =>  _u1 = v, _u1, value,  "U1", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcParameterValue @V1 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _v1;
				((IPersistEntity)this).Activate(false);
				return _v1;
			} 
			set
			{
				SetValue( v =>  _v1 = v, _v1, value,  "V1", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcParameterValue @U2 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _u2;
				((IPersistEntity)this).Activate(false);
				return _u2;
			} 
			set
			{
				SetValue( v =>  _u2 = v, _u2, value,  "U2", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public IfcParameterValue @V2 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _v2;
				((IPersistEntity)this).Activate(false);
				return _v2;
			} 
			set
			{
				SetValue( v =>  _v2 = v, _v2, value,  "V2", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 8)]
		public bool @Usense 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _usense;
				((IPersistEntity)this).Activate(false);
				return _usense;
			} 
			set
			{
				SetValue( v =>  _usense = v, _usense, value,  "Usense", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 9)]
		public bool @Vsense 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _vsense;
				((IPersistEntity)this).Activate(false);
				return _vsense;
			} 
			set
			{
				SetValue( v =>  _vsense = v, _vsense, value,  "Vsense", 7);
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 0)]
		public override IfcDimensionCount @Dim 
		{
			get 
			{
				//## Getter for Dim
			    return BasisSurface.Dim;
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
					_basisSurface = (IfcSurface)(value.EntityVal);
					return;
				case 1: 
					_u1 = value.RealVal;
					return;
				case 2: 
					_v1 = value.RealVal;
					return;
				case 3: 
					_u2 = value.RealVal;
					return;
				case 4: 
					_v2 = value.RealVal;
					return;
				case 5: 
					_usense = value.BooleanVal;
					return;
				case 6: 
					_vsense = value.BooleanVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRectangularTrimmedSurface other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRectangularTrimmedSurface
            var root = (@IfcRectangularTrimmedSurface)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRectangularTrimmedSurface left, @IfcRectangularTrimmedSurface right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcRectangularTrimmedSurface left, @IfcRectangularTrimmedSurface right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@BasisSurface != null)
					yield return @BasisSurface;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}