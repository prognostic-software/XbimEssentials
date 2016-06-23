// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.TopologyResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.GeometricModelResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcManifoldSolidBrep
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcManifoldSolidBrep : IIfcSolidModel
	{
		IIfcClosedShell @Outer { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.GeometricModelResource
{
	[ExpressType("IfcManifoldSolidBrep", 149)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcManifoldSolidBrep : IfcSolidModel, IIfcManifoldSolidBrep, IEquatable<@IfcManifoldSolidBrep>
	{
		#region IIfcManifoldSolidBrep explicit implementation
		IIfcClosedShell IIfcManifoldSolidBrep.Outer { 
 
 
			get { return @Outer; } 
			set { Outer = value as IfcClosedShell;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcManifoldSolidBrep(IModel model) : base(model) 		{ 
		}

		#region Explicit attribute fields
		private IfcClosedShell _outer;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcClosedShell @Outer 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _outer;
				((IPersistEntity)this).Activate(false);
				return _outer;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _outer = v, _outer, value,  "Outer", 1);
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_outer = (IfcClosedShell)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcManifoldSolidBrep other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcManifoldSolidBrep
            var root = (@IfcManifoldSolidBrep)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcManifoldSolidBrep left, @IfcManifoldSolidBrep right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcManifoldSolidBrep left, @IfcManifoldSolidBrep right)
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