t!t edit propose {if;==;;{args;0};{aget;marerm};{aset;{userid}marrystat;{if;>;{math;-;{time;x;now};{aget;2wk}};{round;{usercreatedat}};1;0}}{set;0;{userid;{args;0}}}{aset;{get;0}marrystat;{if;>;{math;-;{time;x;now};{aget;2wk}};{round;{usercreatedat;{args;0}}};1;0}}{aset;{userid}propelig;{if;==;{aget;kao};{userid};1;{if;!=;832961;{aget;scd};0;{if;==;1;{aget;{userid}bl};16;{if;==;1;{aget;{get;0}bl};17;{if;==;1;{aget;{userid}status};15;{if;==;1;{aget;{get;0}status};6;{if;==;1;{aget;{userid}proposed};3;{if;==;;{args;0};4;{if;==;{userid;{args;0}};`User not found`;5;{if;==;1;{aget;{userid}proby};24;{if;==;1;{aget;{get;0}proby};{if;==;{userid};{aget;{get;0}propose};26;10};{if;==;{userid};{userid;{args;0}};7;{if;==;0;{aget;{userid}marrystat};8;{if;==;0;{aget;{get;0}marrystat};9;{if;==;{get;0};{aget;{userid}propose};2;{if;==;1;{aget;{userid}${get;0}};11;{if;==;1;{aget;{get;0}${userid}};12;1}}}}}}}}}}}}}}}}}}{aset;{userid}propose;{if;==;1;{aget;{userid}propelig};{get;0};{aget;{userid}propose}}}{aset;{get;0}propose;{if;==;{aget;{userid}propelig};1;{userid};{aget;{get;0}propose}}}{switch;{aget;{userid}propelig};1;⛪ | {username}{aget;pre13}{username;{args;0}}.
<@{get;0}>{aget;pre14};0;:x: | An error occured!;10;{aget;pre10}{username;{aget;{get;0}propose}}{aget;pre23};26;{aget;pre26}
<@{aget;{get;0}propose}>{aget;pre14};24;{aget;pre24}
<@{aget;{get;0}propose}>{aget;pre14};10;{aget;pre10}{username;{aget;{userid;{args;0}}propose}}{aget;pre27};2;{aget;pre2}{username;{get;@{userid}propose}}!
<@{aget;{get;0}propose}>{aget;pre14};{aget;pre{aget;{userid}propelig}}}{aset;{userid}proposed;{if;==;{userid};{aget;kao};0;{if;==;1;{aget;{userid}propelig};1;{aget;{userid}proposed}}}}{aset;{get;0}proby;{if;==;1;{aget;{userid}propelig};1;0}}}


t!t test {aset;marerm;```ruby
`Marriage Menu` ```
Always prefix tags with t!t.

1. `t!t propose @user` - Proposes to the user.
2. `t!t marry deny` - Denies the proposal.
3. `t!t marry cancel` - Cancels the proposal.
4. `t!t marry accept` - Accepts the marriage.
5. `t!t divorce` - Divorces a marriage.
6. `t!t status [@user]` - Checks your status. If @user - is specified, it checks the status of that user.
```py
>>> This marriage system was made by Kao#9678```}