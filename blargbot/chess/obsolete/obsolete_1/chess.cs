{trim;{fallback;}
{switch;{lower;{args;0}};
	eval;
		{if;!=;{userid};246903976937783296;:x: You cannot run this!{return}}
		{inject;{args}};
	help;
		{exec;chess_help;{lower;{args}}};
	theme;
		{exec;chess_theme;{lower;{args}}};
	start;
		{exec;chess_start;{lower;{args}}};
	start_debug;
		{exec;force_start;{lower;{args}}};
	stalemate;
		{exec;chess_stalemate;{lower;{args}}};
	move;
		{exec;chess_move;{lower;{args}}};
	promote;
		{exec;chess_promote;{lower;{args}}};
	move_w;
		{exec;chess_move_w;{lower;{args}}};
	board;
		{exec;chess_board;{lower;{args}}};
	debug;
		{exec;chess_debug;{lower;{args}}};
	{switch;{lower;{args;0}};
		forfeit;{void};
		quit;{void};
		stop;{void};
		end;{void};
		:x: Invalid command!
		{return}
	}
	{exec;chess_quit;{lower;{args}}}
}}