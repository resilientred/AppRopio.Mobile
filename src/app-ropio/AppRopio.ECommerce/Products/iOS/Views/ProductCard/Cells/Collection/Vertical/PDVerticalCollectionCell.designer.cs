// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace AppRopio.ECommerce.Products.iOS.Views.ProductCard.Cells.Collection.Vertical
{
    [Register ("PDVerticalCollectionCell")]
    partial class PDVerticalCollectionCell
    {
        [Outlet]
        UIKit.NSLayoutConstraint _bottomCollectionViewConstraint { get; set; }

        [Outlet]
        UIKit.UIView _bottomSeparator { get; set; }

        [Outlet]
        UIKit.UICollectionView _collectionView { get; set; }

        [Outlet]
        AppRopio.Base.iOS.Controls.ARLabel _name { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (_bottomCollectionViewConstraint != null) {
                _bottomCollectionViewConstraint.Dispose ();
                _bottomCollectionViewConstraint = null;
            }

            if (_bottomSeparator != null) {
                _bottomSeparator.Dispose ();
                _bottomSeparator = null;
            }

            if (_collectionView != null) {
                _collectionView.Dispose ();
                _collectionView = null;
            }

            if (_name != null) {
                _name.Dispose ();
                _name = null;
            }
        }
    }
}