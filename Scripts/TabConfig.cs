using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace MaterialUI
{
	public class TabConfig : MonoBehaviour
	{
		public string tabName;

		protected TabConfig _hideTab;
		protected Image _tabStripImage;

		void Awake()
		{
			Init ();
		}

		public virtual void Init ()
		{
			if (_tabStripImage)
			{
				return;
			}

			// Name the game object "Tab Strip" to indicate related
			// "Widget.TabWidget" "tabStripEnabled"
			_tabStripImage = GameObject.Find(this.gameObject.name + "/Button Layer/Tab Strip").GetComponent<Image> ();
			_tabStripImage.enabled = false;
		}

		public void Show(TabConfig tabToHide)
		{
			_hideTab = tabToHide;
			Show();
		}

		public void Show ()
		{
			if (_hideTab && _hideTab != this)
			{
				_hideTab.HideWithoutTransition();
				_hideTab = null;
			}
			Select ();
		}

		public void HideWithoutTransition ()
		{
			Deselect ();
		}

		// Getter for tabName property
		public virtual string Name ()
		{
			return tabName;
		}

		protected virtual void Select ()
		{
			_tabStripImage.enabled = true;
		}

		protected virtual void Deselect ()
		{
			_tabStripImage.enabled = false;
		}
	}
}
