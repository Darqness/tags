{if;!=;top;{lower;{args;0}};
	{trim;
		{set;@{userid}time;{time;x}}
		{set;@{userid}oslotmath;
			{get;@{userid}slotmath}
		}
		{set;@{userid}slotmath;
			{math;+;
				{get;@{userid}time};
				{get;@slotcool}
			}
		}
		{set;@{userid}sslotmath;
			{if;>=;
				{get;@{userid}time};
				{get;@{userid}oslotmath};
				1;
				0
			}
		}
		{if;==;0;
			{get;@{userid}sslotmath};
				{set;@{userid}slotmath;
				{get;@{userid}oslotmath}
				}
		}
		{set;@{userid}refmath;
			{math;-;
				{get;@{userid}oslotmath};
				{get;@{userid}time}
			}
		}
		{//;Buggy
			{set;@{userid}ototmath;
				{if;==;NaN;
				{parseint;
					{get;@{userid}totmath}
				};
					0;
					{get;@{userid}totmath}
				}
			}
			{set;@{userid}totmath;
				{math;+;
				{get;@{userid}time};
				{get;@totcool}
				}
			}
			{if;==;1;1;
				{set;@{userid}ototmath;0}
			}
			{set;@{userid}stotmath;
				{if;>=;
				{get;@{userid}time};
				{get;@{userid}ototmath};
					1;
					0
				}
			}
			{if;==;0;
				{get;@{userid}stotmath};
				{set;@{userid}totmath;
					{get;@{userid}ototmath}
				}
			}
			{set;@{userid}totrefmath;
				{math;-;
				{get;@{userid}ototmath};
				{get;@{userid}time}
				}
			}
		}
		{//;Buggy
			{if;!=;1;
				{get;@{userid}stotmath};
				❌ **| {username}, you have reached your daily limit!** Wait for **{abs;{time;HH;{get;@{userid}totrefmath};x}}** hours, **{abs;{time;mm;{get;@{userid}totrefmath};x}}** minutes, and **{abs;{time;ss;{get;@{userid}totrefmath};x}}** seconds
				{return}
			}
		}
		{if;!=;1;
			{get;@{userid}sslotmath};
				❌ **| {username}, please cool down! ({abs;{time;ss;{get;@{userid}refmath};x}} seconds)**
				{return}
		}
		{set;@bet;
			{if;==;0;
				{argslength};1;
				{abs;{floor;{args;0}}}
			}
		}
		{set;@scheck;
			{if;>;
				{get;@bet};
				{get;@sll};
				{get;@sll};
				{if;>;1;
					{get;@bet};1;
					{get;@bet}
				}
			}
		}
		{if;<;
			{get;@{userid}credits};
			{get;@scheck};
				**❎ | {username}, you do not have enough credits to make this bet. Do `b!t daily` to get more credits!**
				{return}
		}
		{set;@fr1;
			{randchoose;🍌;🍒;
				🍐;🍈;🍇;🍊;🍉;🇱🇻;
				🍌;🍒;🔔;🇱🇻;7⃣;💎}
		}
		{set;@fr2;
			{randchoose;🍌;🍒;
				🍐;🍈;🍇;🍊;🍉;🇱🇻;
				🍌;🍒;🔔;🇱🇻;7⃣;💎}
		}
		{set;@fr3;
			{randchoose;🍌;🍒;
				🍐;🍈;🍇;🍊;🍉;
				🍌;🍒;🔔;🇱🇻;7⃣;💎}
		}
		{switch;{randint;1;10};
			1;{randchoose;
				{set;@fr1;{get;@fr2}};
				{set;@fr2;{get;@fr3}};
				{set;@fr3;{get;@fr1}}
				};
			5;
				{set;@fr{randint;1;3};
				{randchoose;💎;🔔;7⃣;🇱🇻}
				}
		}
		{set;@frs1;
			{randchoose;🍌;🍒;🍐;🍈;🍇;🍊;🍉;🔔;🇱🇻;7⃣;💎}{space;2}:{space;2}{randchoose;🍌;🍒;🍐;🍈;🍇;🍊;🍉;🔔;🇱🇻;7⃣;💎}{space;2}:{space;2}{randchoose;🍌;🍒;🍐;🍈;🍇;🍊;🍉;🔔;🇱🇻;7⃣;💎}
		}
		{set;@frs2;
			{randchoose;🍌;🍒;🍐;🍈;🍇;🍊;🍉;🔔;🇱🇻;7⃣;💎}{space;2}:{space;2}{randchoose;🍌;🍒;🍐;🍈;🍇;🍊;🍉;🔔;🇱🇻;7⃣;💎}{space;2}:{space;2}{randchoose;🍌;🍒;🍐;🍈;🍇;🍊;🍉;🔔;🇱🇻;7⃣;💎}
		}
		{set;@fruit;
			{get;@fr1}{get;@fr2}{get;@fr3}
		}
		{set;@pay;
			{switch;{get;@fruit};
				💎💎💎;100;
				7⃣7⃣7⃣;75;
				🔔🔔🔔;75;
				🇱🇻🇱🇻🇱🇻;30;
				🍉🍉🍉;10;
				🍊🍊🍊;10;
				🍇🍇🍇;10;
				🍈🍈🍈;10;
				🍐🍐🍐;10;
				🍒🍒🍒;3;
				🍌🍌🍌;1;
				{switch;{get;@fruit};
					💎💎{get;@fr3};20;
					{get;@fr1}💎💎;20;
					💎{get;@fr2}💎;20;
					🇱🇻🇱🇻{get;@fr3};10;
					{get;@fr1}🇱🇻🇱🇻;10;
					🇱🇻{get;@fr2}🇱🇻;10;
					🍒🍒{get;@fr3};1;
					{get;@fr1}🍒🍒;1;
					🍒{get;@fr2}🍒;1;
					NaN
				}
			}
		}
		{set;@cfr1;
			{switch;{get;@fr1};
				🍌;1;🍒;2;🔔;3;
				{get;@fr1}
			}
		}
		{set;@cfr2;
			{switch;{get;@fr2};
				🍌;4;🍒;5;🔔;6;
				{get;@fr2}
			}
		}
		{set;@cfr3;
			{switch;{get;@fr3};
				🍌;7;🍒;8;🔔;9;
				{get;@fr3}
			}
		}
		{set;@cpay;
			{if;!=;NaN;
				{get;@pay};
					{get;@pay};
					{if;==;
						{get;@cfr1};{get;@cfr2};3;
					{if;==;
						{get;@cfr2};{get;@cfr3};3;
					{if;==;
						{get;@cfr1};{get;@cfr3};3;0
					}}}
				}
		}
**[ 🎰 l SLOTS ]**
{repeat;-;18}
{get;@frs1}

{get;@fr1}{space;2}:{space;2}{get;@fr2}{space;2}:{space;2}{get;@fr3} <

{get;@frs2}
{repeat;-;18}
| : : : {if;>;{get;@cpay};0;: **WIN** :;**LOST**} : : : |
		{void;
			{set;@smath;
				{math;*;
					{get;@scheck};
					{get;@cpay}
				}
			}
			{if;==;100;
				{get;@cpay};
					{if;==;
						{get;@scheck};
						{get;@sll};
							{set;@smath;
								{get;@spool}
							}
					}
			}
			{set;@{userid}stot;
				{math;+;
					{get;@smath};
					0{get;@{userid}stot}
				}
			}
			{set;@{userid}ustot;
				{math;+;
					{get;@smath};
					0{get;@{userid}ustot}
				}
			}
			{set;@mcheck;
				{if;==;NaN;
					{parseint;{get;@smath}};0;
						{get;@smath}
				}
			}
			{set;@{userid}credits;
				{if;>=;
					0{get;@{userid}credits};
					{get;@scheck};
						{math;+;
							{math;-;
								0{get;@{userid}credits};
								{get;@scheck}
							};
							{get;@smath}
						};
						{get;@{userid}credits}
				}
			}
		}
**{username}** used **{get;@scheck}** credit(s) and {if;<;0;
	{get;@cpay};
		won **{get;@smath}** credits!{void;
		{set;@spool;
			{math;+;
				0{get;@spool};
				{get;@scheck}
			}
		}
		{set;@0;
			{regexreplace;
				{get;@sldboard};
				/(\d+#)(\d{1,18})/g;
				$2
			}
		}
		{if;==;-1;
			{indexof;
				{get;@0};
				{userid}
			};
				{push;
					@sldboard;
					{get;@{userid}ustot}#{userid}
				}
		}
		{if;>;
			{length;
				{get;@{userid}ustot}
			};
			{get;@scrlength};
				{set;@scrlength;
					{length;
						{get;@{userid}ustot}
					}
				}
		}
		{set;nw;
			{pad;
				left;
				{repeat;0;{get;@scrlength}};
				{get;@{userid}ustot}
			}
		}
		{inject;
			{lb}set{semi}@sldboard{semi}
				{lb}regexreplace{semi}
					{lb}get{semi}@sldboard{rb}{semi}
					/\d+(?=#{userid})/g{semi}
					{get;nw}
				{rb}
			{rb}
		}};
		lost all of it.}
Total Credits: **{get;@{userid}credits}**
		{exec;ldchk}
	};
	{trim;
		{sort;{get;@sldboard};descending}
		{set;@0;
			{regexreplace;
				{get;@sldboard};
				/(\d+#)(\d{1,18})/g;
				$2
			}
		}
		{set;mx;
			{length;
				{get;@0}
			}
		}
		{set;maxpg;
			{ceil;
				{math;/;
					{get;mx};
					10
				}
			}
		}
		{set;pg;
			{if;==;1;{argslength};1;
			{if;==;NaN;{parseint;{args;1}};1;
			{if;>;{args;1};{get;maxpg};{get;maxpg};
			{if;==;0;{floor;{args;1}};1;
			{abs;{floor;{args;1}}}
			}}}}
		}
		{set;mg;
			{math;*;
				10;
				{math;-;
					{get;pg};1
				}
			}
		}
		{set;@1;
			{slice;{get;@0};
				{get;mg};
				{math;+;1;
					{get;mg}}
				}
		}
		{set;@2;
			{slice;{get;@0};
				{math;+;1;
					{get;mg}
				};
				{math;+;2;
					{get;mg}
				}
			}
		}
		{set;@3;
			{slice;{get;@0};
				{math;+;2;
					{get;mg}
				};
				{math;+;3;
					{get;mg}
				}
			}
		}
		{set;@4;
			{slice;{get;@0};
				{math;+;3;
					{get;mg}
				};
				{math;+;4;
					{get;mg}
				}
			}
		}
		{set;@5;
			{slice;{get;@0};
				{math;+;4;
					{get;mg}
				};
				{math;+;5;
					{get;mg}
				}
			}
		}
		{set;@6;
			{slice;{get;@0};
				{math;+;5;
					{get;mg}
				};
				{math;+;6;
					{get;mg}
				}
			}
		}
		{set;@7;
			{slice;{get;@0};
				{math;+;6;
					{get;mg}
				};
				{math;+;7;
					{get;mg}
				}
			}
		}
		{set;@8;
			{slice;{get;@0};
				{math;+;7;
					{get;mg}
				};
				{math;+;8;
					{get;mg}
				}
			}
		}
		{set;@9;
			{slice;{get;@0};
				{math;+;8;
					{get;mg}
				};
				{math;+;9;
					{get;mg}
				}
			}
		}
		{set;@10;
			{slice;{get;@0};
				{math;+;9;
					{get;mg}
				};
				{math;+;10;
					{get;mg}
				}
			}
		}
		{set;@id;
			{if;!=;1;
				{get;@{userid}admin};0;
					{if;==;id;
						{lower;{args;2}};1;0
					}
			}
		}
	}🎰 **|  Slots Leaderboard**
```py
📋 Rank | Name                  

{trim;
{if;==;1;
	{length;{get;@1}};
		{if;<=;16;
			{length;
				{userid;{get;@1}}};{pad;right;{space;9};[{math;+;1;{get;mg}}]}> #{username;{get;@1}} {if;==;1;{get;@id};({userid;{get;@1}})}
{space;6}Won: {get;@{userid;{get;@1}}ustot}
		}
}
{if;==;1;
	{length;{get;@2}};
		{if;<=;16;{length;{userid;{get;@2}}};{pad;right;{space;9};[{math;+;2;{get;mg}}]}> #{username;{get;@2}} {if;==;1;{get;@id};({userid;{get;@2}})}
{space;6}Won: {get;@{userid;{get;@2}}ustot}
		}
}
{if;==;1;
	{length;{get;@3}};
		{if;<=;16;{length;{userid;{get;@3}}};{pad;right;{space;9};[{math;+;3;{get;mg}}]}> #{username;{get;@3}} {if;==;1;{get;@id};({userid;{get;@3}})}
{space;6}Won: {get;@{userid;{get;@3}}ustot}
		}
}                     
{if;==;1;
	{length;{get;@4}};
		{if;<=;16;{length;{userid;{get;@4}}};{pad;right;{space;9};[{math;+;4;{get;mg}}]}> #{username;{get;@4}} {if;==;1;{get;@id};({userid;{get;@4}})}
{space;6}Won: {get;@{userid;{get;@4}}ustot}
		}
}
{if;==;1;
	{length;{get;@5}};
		{if;<=;16;{length;{userid;{get;@5}}};{pad;right;{space;9};[{math;+;5;{get;mg}}]}> #{username;{get;@5}} {if;==;1;{get;@id};({userid;{get;@5}})}
{space;6}Won: {get;@{userid;{get;@5}}ustot}
		}
}
{if;==;1;
	{length;{get;@6}};
		{if;<=;16;{length;{userid;{get;@6}}};{pad;right;{space;9};[{math;+;6;{get;mg}}]}> #{username;{get;@6}} {if;==;1;{get;@id};({userid;{get;@6}})}
{space;6}Won: {get;@{userid;{get;@6}}ustot}
		}
}
{if;==;1;
	{length;{get;@7}};
		{if;<=;16;{length;{userid;{get;@7}}};{pad;right;{space;9};[{math;+;7;{get;mg}}]}> #{username;{get;@7}} {if;==;1;{get;@id};({userid;{get;@7}})}
{space;6}Won: {get;@{userid;{get;@7}}ustot}
		}
}
{if;==;1;
	{length;{get;@8}};
		{if;<=;16;{length;{userid;{get;@8}}};{pad;right;{space;9};[{math;+;8;{get;mg}}]}> #{username;{get;@8}} {if;==;1;{get;@id};({userid;{get;@8}})}
{space;6}Won: {get;@{userid;{get;@8}}ustot}
		}
}                      
{if;==;1;
	{length;{get;@9}};
		{if;<=;16;{length;{userid;{get;@9}}};{pad;right;{space;9};[{math;+;9;{get;mg}}]}> #{username;{get;@9}} {if;==;1;{get;@id};({userid;{get;@9}})}
{space;6}Won: {get;@{userid;{get;@9}}ustot}
		}
}
{if;==;1;
	{length;{get;@10}};
		{if;<=;16;{length;{userid;{get;@10}}};{pad;right;{space;9};[{math;+;10;{get;mg}}]}> #{username;{get;@10}} {if;==;1;{get;@id};({userid;{get;@10}})}
{space;6}Won: {get;@{userid;{get;@10}}ustot}
		}
}}
{repeat;-;38}
# Your Slot Stats
😐 Rank: 	{math;+;1;
							{indexof;
								{get;@0};
								{userid}
							}
						}/{get;mx} Won: {get;@{userid}ustot}
Prize Pool: {get;@spool}```
}