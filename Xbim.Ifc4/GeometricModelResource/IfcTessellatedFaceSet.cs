// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.PresentationAppearanceResource;
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
    /// Readonly interface for IfcTessellatedFaceSet
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTessellatedFaceSet : IIfcTessellatedItem
	{
		IIfcCartesianPointList3D @Coordinates { get;  set; }
		IItemSet<IItemSet<IfcParameterValue>> @Normals { get; }
		IfcBoolean? @Closed { get;  set; }
		IEnumerable<IIfcIndexedColourMap> @HasColours {  get; }
		IEnumerable<IIfcIndexedTextureMap> @HasTextures {  get; }
	
	}
}

namespace Xbim.Ifc4.GeometricModelResource
{
	[ExpressType("IfcTessellatedFaceSet", 1299)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcTessellatedFaceSet : IfcTessellatedItem, IIfcTessellatedFaceSet, IEquatable<@IfcTessellatedFaceSet>
	{
		#region IIfcTessellatedFaceSet explicit implementation
		IIfcCartesianPointList3D IIfcTessellatedFaceSet.Coordinates { 
 
 
			get { return @Coordinates; } 
			set { Coordinates = value as IfcCartesianPointList3D;}
		}	
		IItemSet<IItemSet<IfcParameterValue>> IIfcTessellatedFaceSet.Normals { 
			get { return @Normals; } 
		}	
		IfcBoolean? IIfcTessellatedFaceSet.Closed { 
 
			get { return @Closed; } 
			set { Closed = value;}
		}	
		 
		IEnumerable<IIfcIndexedColourMap> IIfcTessellatedFaceSet.HasColours {  get { return @HasColours; } }
		IEnumerable<IIfcIndexedTextureMap> IIfcTessellatedFaceSet.HasTextures {  get { return @HasTextures; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTessellatedFaceSet(IModel model) : base(model) 		{ 
			_normals = new OptionalItemSet<IItemSet<IfcParameterValue>>( this, 0,  2);
		}

		#region Explicit attribute fields
		private IfcCartesianPointList3D _coordinates;
		private readonly OptionalItemSet<IItemSet<IfcParameterValue>> _normals;
		private IfcBoolean? _closed;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcCartesianPointList3D @Coordinates 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _coordinates;
				((IPersistEntity)this).Activate(false);
				return _coordinates;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _coordinates = v, _coordinates, value,  "Coordinates", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.List, 3, 3, 4)]
		public IOptionalItemSet<IItemSet<IfcParameterValue>> @Normals 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _normals;
				((IPersistEntity)this).Activate(false);
				return _normals;
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcBoolean? @Closed 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _closed;
				((IPersistEntity)this).Activate(false);
				return _closed;
			} 
			set
			{
				SetValue( v =>  _closed = v, _closed, value,  "Closed", 3);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("MappedTo")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, 1, 6)]
		public IEnumerable<IfcIndexedColourMap> @HasColours 
		{ 
			get 
			{
				return Model.Instances.Where<IfcIndexedColourMap>(e => Equals(e.MappedTo), "MappedTo", this);
			} 
		}
		[InverseProperty("MappedTo")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 7)]
		public IEnumerable<IfcIndexedTextureMap> @HasTextures 
		{ 
			get 
			{
				return Model.Instances.Where<IfcIndexedTextureMap>(e => Equals(e.MappedTo), "MappedTo", this);
			} 
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_coordinates = (IfcCartesianPointList3D)(value.EntityVal);
					return;
				case 1: 
					((ItemSet<IfcParameterValue>)_normals
						.InternalGetAt(nestedIndex[0]) )
						.InternalAdd((IfcParameterValue)(value.RealVal));
					return;
				case 2: 
					_closed = value.BooleanVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTessellatedFaceSet other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTessellatedFaceSet
            var root = (@IfcTessellatedFaceSet)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTessellatedFaceSet left, @IfcTessellatedFaceSet right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcTessellatedFaceSet left, @IfcTessellatedFaceSet right)
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