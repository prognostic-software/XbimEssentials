// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PresentationDefinitionResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcAnnotationSurface
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcAnnotationSurface : IIfcGeometricRepresentationItem
	{
		IIfcGeometricRepresentationItem @Item { get;  set; }
		IIfcTextureCoordinate @TextureCoordinates { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.PresentationDefinitionResource
{
	[ExpressType("IfcAnnotationSurface", 731)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAnnotationSurface : IfcGeometricRepresentationItem, IInstantiableEntity, IIfcAnnotationSurface, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcAnnotationSurface>
	{
		#region IIfcAnnotationSurface explicit implementation
		IIfcGeometricRepresentationItem IIfcAnnotationSurface.Item { 
 
 
			get { return @Item; } 
			set { Item = value as IfcGeometricRepresentationItem;}
		}	
		IIfcTextureCoordinate IIfcAnnotationSurface.TextureCoordinates { 
 
 
			get { return @TextureCoordinates; } 
			set { TextureCoordinates = value as IfcTextureCoordinate;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAnnotationSurface(IModel model) : base(model) 		{ 
		}

		#region Explicit attribute fields
		private IfcGeometricRepresentationItem _item;
		private IfcTextureCoordinate _textureCoordinates;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcGeometricRepresentationItem @Item 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _item;
				((IPersistEntity)this).Activate(false);
				return _item;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _item = v, _item, value,  "Item", 1);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 4)]
		public IfcTextureCoordinate @TextureCoordinates 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _textureCoordinates;
				((IPersistEntity)this).Activate(false);
				return _textureCoordinates;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _textureCoordinates = v, _textureCoordinates, value,  "TextureCoordinates", 2);
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_item = (IfcGeometricRepresentationItem)(value.EntityVal);
					return;
				case 1: 
					_textureCoordinates = (IfcTextureCoordinate)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcAnnotationSurface other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcAnnotationSurface
            var root = (@IfcAnnotationSurface)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcAnnotationSurface left, @IfcAnnotationSurface right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcAnnotationSurface left, @IfcAnnotationSurface right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Item != null)
					yield return @Item;
				if (@TextureCoordinates != null)
					yield return @TextureCoordinates;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@TextureCoordinates != null)
					yield return @TextureCoordinates;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}