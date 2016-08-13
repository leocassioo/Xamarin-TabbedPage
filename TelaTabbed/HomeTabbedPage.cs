using System;

using Xamarin.Forms;

namespace TelaTabbed
{
	public class HomeTabbedPage : TabbedPage
	{
		public HomeTabbedPage()
		{
			TelaTabbedPage tela1 = new TelaTabbedPage();
			SegundaTela tela2 = new SegundaTela();

			this.Children.Add(tela1);
			this.Children.Add(tela2);

		}
	}
}


