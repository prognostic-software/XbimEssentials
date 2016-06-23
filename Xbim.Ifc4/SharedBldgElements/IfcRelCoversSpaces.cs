// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.ProductExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.SharedBldgElements;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelCoversSpaces
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelCoversSpaces : IIfcRelConnects
	{
		IIfcSpace @RelatingSpace { get;  set; }
		IItemSet<IIfcCovering> @RelatedCoverings { get; }
	
	}
}

namespace Xbim.Ifc4.SharedBldgElements
{
	[ExpressType("IfcRelCoversSpaces", 17)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelCoversSpaces : IfcRelConnects, IInstantiableEntity, IIfcRelCoversSpaces, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelCoversSpaces>
	{
		#region IIfcRelCoversSpaces explicit implementation
		IIfcSpace IIfcRelCoversSpaces.RelatingSpace { 
 
 
			get { return @RelatingSpace; } 
			set { RelatingSpace = value as IfcSpace;}
		}	
		IItemSet<IIfcCovering> IIfcRelCoversSpaces.RelatedCoverings { 
			get { return new Common.Collections.ProxyItemSet<IfcCovering, IIfcCovering>( @RelatedCoverings); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelCoversSpaces(IModel model) : base(model) 		{ 
			_relatedCoverings = new ItemSet<IfcCovering>( this, 0,  6);
		}

		#region Explicit attribute fields
		private IfcSpace _relatingSpace;
		private readonly ItemSet<IfcCovering> _relatedCoverings;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 5)]
		public IfcSpace @RelatingSpace 
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
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 6)]
		public IItemSet<IfcCovering> @RelatedCoverings 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedCoverings;
				((IPersistEntity)this).Activate(false);
				return _relatedCoverings;
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
					_relatingSpace = (IfcSpace)(value.EntityVal);
					return;
				case 5: 
					_relatedCoverings.InternalAdd((IfcCovering)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelCoversSpaces other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelCoversSpaces
            var root = (@IfcRelCoversSpaces)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelCoversSpaces left, @IfcRelCoversSpaces right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcRelCoversSpaces left, @IfcRelCoversSpaces right)
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
				foreach(var entity in @RelatedCoverings)
					yield return entity;
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
				foreach(var entity in @RelatedCoverings)
					yield return entity;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}