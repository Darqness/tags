{lang;js}
{if;<;{get;~v1};{get;v2};:x: Invalid move! The pawn can not move backwards!
	{return}
}
{set;~hor;{if;==;{get;~hor1};{math;+;{get;~hor2};1};1;0}}
{set;~ver;
	{switch;{get;~ver2};
		{math;+;{get;~ver1};1};1;
		{math;+;{get;~ver1};2};2;
		0
	}
}
{switch;{get;~hor};
	0;
		{switch;{get;~ver};
			1;1;
			2;
				{if;==;1;{get;@{get;~p}unmoved$p{get;~mv1}};1;0{set;~explain;pawn_2mv}}
		};
	1;
		{switch;{get;~ver};
			0;0;
			1;
				{switch;{get;@{userid}chess_color};
					w;{if;==;1;{get;~side_2};1;0}
					b;{if;==;2;{get;~side_2};1;0}
				};
			2;0;
			0
		}
}
{set;~h;
	{switch;{get;~hor1};
		{math;+;{get;~hor2};1};1;
		0
	}
}
{set;~v;
	{switch;{get;~ver1};
		{math;+;{get;~ver2};1};1;
		{math;+;{get;~ver2};2};2;
		0
	}
}
{switch;{get;~hor};
	0;
		{switch;{get;~ver};
			1;
				{switch;{get;~side_2};
					0;
						{set;@{get;~p}{get;~mv2};{get;~piece}}
						{set;@{get;~p}{get;~mv1};-}
						{set;~move_success;true}
						{set;~move_type;null};
					1;:x: You can not move your piece here!
							{set;~continue;false}
							{set;~exp;taken_space};
					2;:x: You can not move your piece here!
							{set;~continue;false}
							{set;~exp;taken_space};
				};
			2;
				{if;!=;-;{get;@{get;~p}{get;~h2}{get;~{math;-;{get;~v2};1}}};
					:x: You can not move your piece here!
					{set;~continue;false}
					{set;~exp;taken_space}
					{return}
				}
				{if;==;1;{get;@{get;~p}unmoved$P{get;~mv1}};
					{switch;{get;~side_2};
						0;
							{set;@{get;~p}{get;~mv2};{get;~piece}}
							{set;@{get;~p}{get;~mv1};-}
							{set;~move_success;true}
							{set;~move_type;null};
						1;:x: You can not move your piece here!
								{set;~continue;false}
								{set;~exp;taken_space};
						2;:x: You can not move your piece here!
								{set;~continue;false}
								{set;~exp;taken_space};
					};
					0{set;~explain;pawn_2mv}
				}
		};
	1;
		{switch;{get;~ver};
			0;:x: You can not move your piece here!
				{set;~continue;false}
				{set;~exp;taken_space};
			1;
				{switch;{get;~side_2};
					0;:x: You can not move your piece here!
						{set;@{get;~p}{get;~mv2};{get;~piece}}
						{set;@{get;~p}{get;~mv1};-}
						{set;~move_type;null}
					1;
						{if;!=;w;{get;@{userid}chess_color};:x: You can not move your piece here!
							{set;~continue;false}
							{set;~exp;taken_space};
							{set;@{get;~p}{get;~mv2};{get;~piece}}
							{set;@{get;~p}{get;~mv1};-}
							{if;==;1;{get;~king};{set;~won;1}}
							{set;~move_success;true}
							{set;~move_type;eat}
						}
					2;
						{if;!=;b;{get;@{userid}chess_color};:x: You can not move your piece here!
							{set;~continue;false}
							{set;~exp;taken_space};
							{set;@{get;~p}{get;~mv2};{get;~piece}}
							{set;@{get;~p}{get;~mv1};-}
							{if;==;1;{get;~king};{set;~won;1}}
							{set;~move_success;true}
							{set;~move_type;eat}
						}
				};
			2;:x: You can not move your piece here!
				{set;~continue;false};
			0
		}
}