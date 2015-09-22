using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace MaterialUI
{
	public class BottomTabConfig : TabConfig
	{
		// Tab Image is used to hightlight the entire tab
		protected Image _tabImage;

		public override void Init ()
		{
			// return if we're already setup
			if (_tabImage)
			{
				return;
			}

			_tabImage = gameObject.GetComponent<Image>();
			if (_tabImage == null)
			{
				_tabImage = gameObject.AddComponent<Image>();
			}
			Deselect ();
		}

		protected override void Select ()
		{
			_tabImage.enabled      = true;
		}
		protected override void Deselect ()
		{
			_tabImage.enabled      = false;
		}
	}
}
