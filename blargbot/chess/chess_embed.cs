{lang;cs}
{embed;
	{buildembed;
		author.icon_url:
			{useravatar};
		author.name:
			{usernick};
		{if;!=;;{get;~color};
			color:
				{get;~color};
		}
		description:
			**[Board]({get;~link})**;
		{if;{get;~tm};
			footer.icon_url:
				{if;==;w;{get;@{get;~p}tm};
					https://cdn.discordapp.com/emojis/432200723724369920.png;
					https://cdn.discordapp.com/emojis/432200721820155924.png
				};
			footer.text:
				{username;{get;@{get;~p}p{if;==;w;{get;@{get;~p}tm};1;2}}}{get;@aph}s turn;
		}
		image.url:
			{get;~link};
		{if;!=;;{get;@{get;~p}previous};
			thumbnail.url:
				{get;@{get;~p}previous};
		}
		timestamp:
			{time};
		title:
			{get;@{get;~p}move}{switch;{get;@{get;~p}move};11;ᵗʰ;12;ᵗʰ;13;ᵗʰ;{switch;{substring;{get;@{get;~p}move};{math;-;{length;{get;@{get;~p}move}};1}};1;ˢᵗ;2;ⁿᵈ;3;ʳᵈ;ᵗʰ}} Move;
	}
}