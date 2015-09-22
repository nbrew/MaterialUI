using UnityEngine;
using System.Collections;

namespace MaterialUIExtended
{
	public class TabManager : MonoBehaviour
	{
		public TabConfig[] tabs;
		public TabConfig initialTab;

		[HideInInspector]
		public TabConfig currentTab;

		void Awake ()
		{
			if (initialTab != null)
			{
				initialTab.Init ();
				initialTab.Show ();
				currentTab = initialTab;
			}
		}

		public void Set (int index)
		{
			tabs[index].Show (currentTab);
			currentTab = tabs[index];
		}

		public void Set (string name)
		{
			for (int i = 0; i < tabs.Length; i++)
			{
				if (tabs[i].Name () == name)
				{
					Set (i);
					return;
				}
			}
		}
	}
}
