﻿int thisCannotBeNull = 4;
//thisCannotBeNull = null;
WriteLine(thisCannotBeNull);
int? thisCouldBeNull = null;
WriteLine(thisCouldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());
thisCouldBeNull = 7;
WriteLine(thisCouldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());
// the actual type of int? is Nullable<int>
Nullable<int> thisCouldAlsoBeNull  = null;
thisCouldAlsoBeNull = 9;
WriteLine(thisCouldAlsoBeNull);