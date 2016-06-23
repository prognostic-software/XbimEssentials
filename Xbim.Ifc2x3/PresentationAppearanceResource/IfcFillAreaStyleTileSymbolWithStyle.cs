// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.PresentationDefinitionResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PresentationAppearanceResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcFillAreaStyleTileSymbolWithStyle
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcFillAreaStyleTileSymbolWithStyle : IIfcGeometricRepresentationItem, IfcFillAreaStyleTileShapeSelect
	{
		IIfcAnnotationSymbolOccurrence @Symbol { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[ExpressType("IfcFillAreaStyleTileSymbolWithStyle", 726)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcFillAreaStyleTileSymbolWithStyle : IfcGeometricRepresentationItem, IInstantiableEntity, IIfcFillAreaStyleTileSymbolWithStyle, IContainsEntityReferences, IEquatable<@IfcFillAreaStyleTileSymbolWithStyle>
	{
		#region IIfcFillAreaStyleTileSymbolWithStyle explicit implementation
		IIfcAnnotationSymbolOccurrence IIfcFillAreaStyleTileSymbolWithStyle.Symbol { 
 
 
			get { return @Symbol; } 
			set { Symbol = value as IfcAnnotationSymbolOccurrence;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFillAreaStyleTileSymbolWithStyle(IModel model) : base(model) 		{ 
		}

		#region Explicit attribute fields
		private IfcAnnotationSymbolOccurrence _symbol;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcAnnotationSymbolOccurrence @Symbol 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _symbol;
				((IPersistEntity)this).Activate(false);
				return _symbol;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _symbol = v, _symbol, value,  "Symbol", 1);
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_symbol = (IfcAnnotationSymbolOccurrence)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcFillAreaStyleTileSymbolWithStyle other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcFillAreaStyleTileSymbolWithStyle
            var root = (@IfcFillAreaStyleTileSymbolWithStyle)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcFillAreaStyleTileSymbolWithStyle left, @IfcFillAreaStyleTileSymbolWithStyle right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcFillAreaStyleTileSymbolWithStyle left, @IfcFillAreaStyleTileSymbolWithStyle right)
        {
            return !(left == right);
        }

        public static bool operator ==(@IfcFillAreaStyleTileSymbolWithStyle left, IfcFillAreaStyleTileShapeSelect right)
		{
			return left == right as @IfcFillAreaStyleTileSymbolWithStyle;
		}

		public static bool operator !=(@IfcFillAreaStyleTileSymbolWithStyle left, IfcFillAreaStyleTileShapeSelect right)
		{
			return !(left == right);
		}

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Symbol != null)
					yield return @Symbol;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}