t!t edit subc {set;user;{userid;{args;0}}}{if;==;{aget;{userid}admin};1;Properties of {username;{get;user}}```ruby
{repeat; ;3}Propose | {aget;{get;user}propose}
{repeat; ;3}Propose | {switch;{aget;{get;user}propose};;None;0;None;{username;{aget;{get;user}propose}}}
{repeat; ;2}Proposed | {aget;{get;user}proposed}
{repeat; ;1}Marrystat | {aget;{get;user}marrystat}
{repeat; ;4}Status | {aget;{get;user}status}
{repeat; ;3}Partner | {aget;{get;user}partner}
{repeat; ;3}Partner | {switch;{aget;{get;user}partner};;None;0;None;{username;{aget;{get;user}partner}}}
{repeat; ;2}Propelig | {aget;{get;user}propelig}
{repeat; ;3}Harelig | {aget;{get;user}harelig}
{repeat; ;5}Proby | {aget;{get;user}proby}
{repeat; ;3}Marelig | {aget;{get;user}marelig}
{repeat; ;2}Marrmath | {aget;{get;user}marrmath}
{repeat; ;2}Marrmath | {time;MM/DD/YYYY hh:mm:ss;{aget;{get;user}marrmath}}
{repeat; ;1}Omarrmath | {aget;{get;user}omarrmath}
{repeat; ;1}Omarrmath | {time;MM/DD/YYYY hh:mm:ss;{aget;{get;user}omarrmath}}
{repeat; ;1}Smarrmath | {aget;{get;user}smarrmath}
{repeat; ;3}Petelig | {aget;{get;user}petelig}
{repeat; ;5}Event | {aget;{get;user}event}
{repeat; ;7}Pet | {aget;{get;user}pet}
{repeat; ;5}Pethp | {aget;{get;user}pethp}
{repeat; ;5}Peten | {aget;{get;user}peten}
{repeat; ;5}Peten | {switch;{aget;{get;user}peten};;None;0;None;{username;{aget;{get;user}peten}}}
{repeat; ;5}Pbact | {aget;{get;user}pbact}
{repeat; ;4}Battop | {aget;{get;user}battop}
{repeat; ;4}Battda | {aget;{get;user}battda}
{repeat; ;7}Paw | {aget;{get;user}paw}
{repeat; ;7}Paw | {switch;{aget;{get;user}paw};;None;0;None;{username;{aget;{get;user}paw}}}
{repeat; ;6}Paw2 | {aget;{get;user}paw2}
{repeat; ;6}Paw2 | {switch;{aget;{get;user}paw2};;None;0;None;{username;{aget;{get;user}paw2}}}
```;{aget;deber}}