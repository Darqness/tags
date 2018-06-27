{lang;js}
{set;~a;1}{set;~1;a}
{set;~b;2}{set;~2;b}
{set;~c;3}{set;~3;c}
{set;~d;4}{set;~4;d}
{set;~e;5}{set;~5;e}
{set;~f;6}{set;~6;f}
{set;~g;7}{set;~7;g}
{set;~h;8}{set;~8;h}
{set;~hor;0}{set;~ver;0}
{set;~move_success;false}
{set;~move_type}
{set;~h1;{get;~{substring;{get;~mv1};0;1}}}
{set;~h2;{get;~{substring;{get;~mv2};0;1}}}
{set;~v1;{substring;{get;~mv1};1;2}}
{set;~v2;{substring;{get;~mv2};1;2}}
{set;~ver1;{if;>;{get;~v1};{get;~v2};{get;~v1};{get;~v2}}}
{set;~ver2;{if;<;{get;~v1};{get;~v2};{get;~v1};{get;~v2}}}
{set;~hor1;{if;>;{get;~h1};{get;~h2};{get;~h1};{get;~h2}}}
{set;~hor2;{if;<;{get;~h1};{get;~h2};{get;~h1};{get;~h2}}}
{set;~p;{get;@{userid}chess_instance}}
{set;~piece;{get;@{get;~p}{get;~mv1}}}
{set;~continue}
{set;~side;
	{switch;{get;@{get;~p}{get;~mv1}};
		-;0;
		r;1;
		n;1;
		b;1;
		q;1;
		k;1;
		p;1;
		P;2;
		Q;2;
		K;2;
		B;2;
		N;2;
		R;2;
		-1
	}
}
{set;~side_2;
	{switch;{get;@{get;~p}{get;~mv2}};
		-;0;
		r;1;
		n;1;
		b;1;
		q;1;
		k;1
			{switch;{get;@{userid}chess_color};
				w;{set;~king;1}
				b;{set;~king;0}b
			};
		p;1;
		P;2;
		Q;2;
		K;2
			{switch;{get;@{userid}chess_color};
				w;{set;~king;0}
				b;{set;~king;1}
			};
		B;2;
		N;2;
		R;2;
		-1
	}
}
{switch;{get;~piece};
	-;0;
	P;	
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
		{switch;{get;~h};
			0;
				{switch;{get;~v};
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
									{set;@{get;~p}unmoved$P{get;~mv1};0}
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
				{switch;{get;~v};
					0;
:x: You can not move your piece here!
{return}
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
					2;
:x: You can not move your piece here!
{return};
					0
				}
		}; 
	Q;	
		{if;!=;{get;~hor1};{get;~hor2};{set;~queen_move;h}}
		{if;!=;{get;~ver1};{get;~ver2};{set;~queen_move;v}}
		{set;~h;{if;!=;{get;~hor1};{get;~hor2};true{set;~queen_move;h};0}}
		{set;~v;{if;!=;{get;~ver1};{get;~ver2};true{set;~queen_move;v};0}}
		{set;~i_h1;{abs;{math;+;{get;~hor2};1}}}
		{set;~i_v1;{abs;{math;+;{get;~ver2};1}}}
		{set;~i_h2;{abs;{math;-;{get;~hor1};1}}}
		{set;~i_v2;{abs;{math;-;{get;~ver1}};1}}
		{if;!=;
			{math;+;{math;-;{get;~hor1};{get;~hor2}};1};
			{math;+;{math;-;{get;~ver1};{get;~ver2}};1};
			{set;~exp;queen_math_not_match}
			:x: FATAL ERROR! Please report to tag creator.
			{return}
		}
		{if;{logic;&&;{get;~h};{get;~v}};
			{set;~i_h1;{get;~h1}}
			{set;~i_v1;{get;~v1}}
			{repeat;
				{void;
					{{if;>;{get;~h1};{get;~h2};de;in}crement;i_h1}
					{{if;>;{get;~v1};{get;~v2};de;in}crement;i_v1}
				}
				{get;~{get;~i_h1}}{get;~i_v1}|
				{if;!=;-;{get;@{get;~p}{get;~{get;~i_h1}}{get;~i_v1}};
					{set;~continue;0}
					{set;~exp;piece_obstruct};
				};{math;-;{math;-;{get;~hor1};{get;~hor2}};1}
			}
			{if;==;0;{get;~continue};:x: You cannot move your piece here!aa
				{set;~continue;false}
				{set;~exp;taken_space}
				{return}
			}
			{switch;{get;~side_2};
				0;
					{set;@{get;~p}{get;~mv2};{get;~piece}}
					{set;@{get;~p}{get;~mv1};-}
					{set;~move_success;true}
					{set;~move_type;null};
				1;
					{if;!=;w;{get;@{userid}chess_color};
:x: You can not move your piece here!
{return}
						{set;~exp;taken_space}
						{return};
						{set;@{get;~p}{get;~mv2};{get;~piece}}
						{set;@{get;~p}{get;~mv1};-}
						{if;==;1;{get;~king};{set;~won;1}}
						{set;~move_success;true}
						{set;~move_type;eat}
						{return}
					};
				2;
					{if;!=;b;{get;@{userid}chess_color};
:x: You can not move your piece here!
{return}
						{set;~exp;taken_space}
						{return};
						{set;@{get;~p}{get;~mv2};{get;~piece}}
						{set;@{get;~p}{get;~mv1};-}
						{if;==;1;{get;~king};{set;~won;1}}
						{set;~move_success;true}
						{set;~move_type;eat}
					}
			};
			{switch;{get;~queen_move};
				h;
					{if;!=;{get;~v1};{get;~v2};
						:x: FATAL ERROR! Please report to tag creator. `v1 and v2 does not match.`
							{return}
					}
					{set;~rank;{get;~v{randint;1;2}}}
					{set;~i_h1;{math;+;{get;~hor2};1}}
					{repeat;
						{if;!=;-;{get;@{get;~p}{get;~{get;~i_h1}}{get;~rank}};
							{set;~continue;false}
							{set;~exp;piece_obstruct};
							{void;
								{increment;i_h1}
							}
						};{math;-;{math;-;{get;~hor1};{get;~hor2};1}}
					}
					{if;==;false;{get;~continue};:x: Invalid move!
						{return}
					}
					{switch;{get;~side_2};
						0;
							{set;@{get;~p}{get;~mv2};{get;~piece}}
							{set;@{get;~p}{get;~mv1};-}
							{if;==;1;{get;~king};{set;~won;1}}												
							{set;~move_success;true}
							{set;~move_type;null};
						1;
							{if;!=;w;{get;@{userid}chess_color};:x: You can not move your piece here!
								{set;~continue;false}
								{set;~exp;taken_space};
								{set;@{get;~p}{get;~mv2};{get;~piece}}
								{set;@{get;~p}{get;~mv1};-}
								{if;==;1;{get;~king};{set;~won;1}}
								{set;~move_success;true}
								{set;~move_type;eat}
							};
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
				v;
					{if;!=;{get;~h1};{get;~h2};
						:x: FATAL ERROR! Please report to tag creator. `h1 and h2 does not match.`
							{return}
					}
					{set;~rank;{get;~{get;~h{randint;1;2}}}}
					{set;~i_v1;{math;+;{get;~ver2};1}}
					{repeat;
						{if;!=;-;{get;@{get;~p}{get;~rank}{get;~i_v1}};
							{set;~continue;false}
							{set;~exp;piece_obstruct};
							{void;
								{increment;i_h1}
							}
						};{math;-;{math;-;{get;~ver1};{get;~ver2};1}}
					}
					{if;==;false;{get;~continue};:x: Invalid move!
						{return}
					}
					{switch;{get;~side_2};
						0;
							{set;@{get;~p}{get;~mv2};{get;~piece}}
							{set;@{get;~p}{get;~mv1};-}
							{if;==;1;{get;~king};{set;~won;1}}												
							{set;~move_success;true}
							{set;~move_type;null};
						1;
							{if;!=;w;{get;@{userid}chess_color};:x: You can not move your piece here!
								{set;~continue;false}
								{set;~exp;taken_space};
								{set;@{get;~p}{get;~mv2};{get;~piece}}
								{set;@{get;~p}{get;~mv1};-}
								{if;==;1;{get;~king};{set;~won;1}}
								{set;~move_success;true}
								{set;~move_type;eat}
							};
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
					}
			}
		};
	K;	
		{switch;{get;~mv2};
			g1;	
				{set;~index;6}
				{repeat;
					{if;!=;-;{get;@{get;~p}{get;~{get;~index}}1};
						{set;~continue;false}
						{set;~exp;piece_obstruct}
						{void;{increment;index}}
					};2
				}
				{if;==;false;{get;~continue};:x: Invalid move!{nl}{get;@{get;~exp}}
					{return}
				}
				{switch;{get;~side_2};
					0;
						{if;!=;R;{get;@{get;~p}h1};:x: FATAL ERROR! Please report to tag creator. `rook not found in h1`
							{return}
						}
						{if;!=;true;{get;~castling};:x: FATAL ERROR! Please report to tag creator. `castling is not true`
							{return}
						}
						{set;@{get;~p}{get;~mv2};{get;~piece}}
						{set;@{get;~p}{get;~mv1};-}
						{set;~move_success;true}
						{set;@{get;~p}f1;R}
						{set;@{get;~p}h1;-}
						{set;@{get;~p}unmoved$R_h1;0};
					:x: FATAL ERROR! `{lb}userid{rb}side_2 out of bounds`
						{return}
				};
			c1;	
				{set;~index;2}
				{repeat;
					{if;!=;-;{get;@{get;~p}{get;~{get;~index}}1};
						{set;~continue;false}
						{set;~exp;piece_obstruct}
						{void;{increment;index}}
					};2
				}
				{if;==;false;{get;~continue};:x: Invalid move!{nl}{get;@{get;~exp}}
					{return}
				}
				{switch;{get;~side_2};
					0;
						{if;!=;R;{get;@{get;~p}h1};:x: FATAL ERROR! Please report to tag creator. `rook not found in h1`
							{return}
						}
						{if;!=;true;{get;~castling};:x: FATAL ERROR! Please report to tag creator. `castling is not true`
							{return}
						}
						{set;@{get;~p}{get;~mv2};{get;~piece}}
						{set;@{get;~p}{get;~mv1};-}
						{set;~move_success;true}
						{set;@{get;~p}f1;R}
						{set;@{get;~p}h1;-}
						{set;@{get;~p}unmoved$R_h1;0};
					:x: FATAL ERROR! `{lb}userid{rb}side_2 out of bounds`
						{return}
				};
			{switch;{get;~side_2};
				0;
					{set;@{get;~p}{get;~mv2};{get;~piece}}
					{set;@{get;~p}{get;~mv1};-}
					{set;~move_success;true}
					{set;~move_type;null};
				1;
					{if;!=;w;{get;@{userid}chess_color};
:x: You can not move your piece here!
{return}
						{set;~exp;taken_space}
						{return}
					}
					{set;@{get;~p}{get;~mv2};{get;~piece}}
					{set;@{get;~p}{get;~mv1};-}
					{if;==;1;{get;~king};{set;~won;1}}
					{set;~move_success;true}
					{set;~move_type;eat};
				2;
					{if;!=;b;{get;@{userid}chess_color};
:x: You can not move your piece here!
{return}
						{set;~exp;taken_space}
						{return}
					}
					{set;@{get;~p}{get;~mv2};{get;~piece}}
					{set;@{get;~p}{get;~mv1};-}
					{if;==;1;{get;~king};{set;~won;1}}
					{set;~move_success;true}
					{set;~move_type;eat}
			}
			{if;==;true;{get;~move_success};{set;@{get;~p}unmoved$K;0}}
		};
	B;	
		{set;~i_h1;{get;~h1}}
		{set;~i_v1;{get;~v1}}
		{repeat;
			{void;
				{{if;>;{get;~h1};{get;~h2};de;in}crement;i_h1}
				{{if;>;{get;~v1};{get;~v2};de;in}crement;i_v1}
			}
			{get;~{get;~i_h1}}{get;~i_v1}|
			{if;!=;-;{get;@{get;~p}{get;~{get;~i_h1}}{get;~i_v1}};
				{set;~continue;0}
				{set;~exp;piece_obstruct};
			};{math;-;{math;-;{get;~hor1};{get;~hor2}};1}
		}
		{if;==;0;{get;~continue};:x: You cannot move your piece here!
			{set;~continue;false}
			{set;~exp;taken_space}
			{return}
		}
		{switch;{get;~side_2};
			0;
				{set;@{get;~p}{get;~mv2};{get;~piece}}											
				{set;~move_success;true}

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
	N;
		{switch;{get;~hor1};
			{math;+;{get;~hor2};1};1{set;~h_m;h};
			{math;+;{get;~hor2};2};2{set;~h_m;v}
		}
		{switch;{get;~ver1};
			{math;+;{get;~ver2};2};1{set;~v_m;h};
			{math;+;{get;~ver2};1};2{set;~v_m;v}
		}
		{set;~i_h;{get;~h2}}
		{set;~i_v;{get;~v2}}
		{if;!=;{get;~h_m};{get;~v_m};
			:x: FATAL ERROR! Please report to tag creator. `h_m and v_m does not match.`
			{return}
		}
		{switch;{get;~side_2};
			0;
				{set;@{get;~p}{get;~mv2};{get;~piece}}
				{set;@{get;~p}{get;~mv1};-}
				{set;~move_success;true}
				{set;~move_type;null};
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
	R;
		{if;!=;{get;~hor1};{get;~hor2};{set;~rook_move;h}}
		{if;!=;{get;~ver1};{get;~ver2};{set;~rook_move;v}}
		{switch;{get;~rook_move};
			h;
				{if;!=;{get;~v1};{get;~v2};
					:x: FATAL ERROR! Please report to tag creator. `v1 and v2 does not match.`
						{return}
				}
				{set;~rank;{get;~v{randint;1;2}}}
				{set;~i_h1;{math;+;{get;~hor2};1}}
				{repeat;
					{if;!=;-;{get;@{get;~p}{get;~{get;~i_h1}}{get;~rank}};
						{set;~continue;false}
						{set;~exp;piece_obstruct};
						{void;
							{increment;i_h1}
						}
					};{math;-;{math;-;{get;~hor1};{get;~hor2};1}}
				}
				{if;==;false;{get;~continue};:x: Invalid move!
					{return}
				}
				{switch;{get;~side_2};
					0;
						{set;@{get;~p}{get;~mv2};{get;~piece}}
						{set;@{get;~p}{get;~mv1};-}
						{if;==;1;{get;~king};{set;~won;1}}												
						{set;~move_success;true}
						{set;~move_type;null};
					1;
						{if;!=;w;{get;@{userid}chess_color};:x: You can not move your piece here!
							{set;~continue;false}
							{set;~exp;taken_space};
							{set;@{get;~p}{get;~mv2};{get;~piece}}
							{set;@{get;~p}{get;~mv1};-}
							{if;==;1;{get;~king};{set;~won;1}}
							{set;~move_success;true}
							{set;~move_type;eat}
						};
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
			v;
				{if;!=;{get;~h1};{get;~h2};
					:x: FATAL ERROR! Please report to tag creator. `h1 and h2 does not match.`
						{return}
				}
				{set;~rank;{get;~{get;~h{randint;1;2}}}}
				{set;~i_v1;{math;+;{get;~ver2};1}}
				{repeat;
					{if;!=;-;{get;@{get;~p}{get;~rank}{get;~i_v1}};
						{set;~continue;false}
						{set;~exp;piece_obstruct};
						{void;
							{increment;i_h1}
						}
					};{math;-;{math;-;{get;~ver1};{get;~ver2};1}}
				}
				{if;==;false;{get;~continue};:x: Invalid move!
					{return}
				}
				{switch;{get;~side_2};
					0;
						{set;@{get;~p}{get;~mv2};{get;~piece}}
						{set;@{get;~p}{get;~mv1};-}
						{if;==;1;{get;~king};{set;~won;1}}												
						{set;~move_success;true}
						{set;~move_type;null};
					1;
						{if;!=;w;{get;@{userid}chess_color};:x: You can not move your piece here!
							{set;~continue;false}
							{set;~exp;taken_space};
							{set;@{get;~p}{get;~mv2};{get;~piece}}
							{set;@{get;~p}{get;~mv1};-}
							{if;==;1;{get;~king};{set;~won;1}}
							{set;~move_success;true}
							{set;~move_type;eat}
						};
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
				}
		}
		{if;==;true;{get;~move_success};
			{switch;{get;~mv1};
				a1;{set;@{get;~p}unmoved$R_a1;0};
				h1;{set;@{get;~p}unmoved$R_h1;0};
			}
		};
	:x: FATAL ERROR! Please report to tag creator. `out of bounds {lb}get{semi}p{rb}{lb}lower{semi}{lb}args{semi}0{rb}{rb}`{set;~continue;0}
}
{exec;chess_move_2;{args}}