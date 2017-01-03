#pragma warning disable 414

using System;
using static Parca;

using _ = System.Action<Contest.Core.Runner>;

class Parcatests {
	_ die = assert =>
		assert.ErrMsg("Foo Error.", ()=> Die("Foo Error."));
	
	_ die_if_cond_is_true = assert =>
		assert.ErrMsg("Foo Error.", ()=> DieIf(1 == 1, "Foo Error."));

	_ live_if_cond_is_false = assert => {
		DieIf(2 == 1, "Foo Error.");
		assert.Pass();
	};

	_ die_unless_cond_is_true = assert => {
		DieUnless(1 == 1, "Foo Error.");
		assert.Pass();
	};

	_ live_unless_cond_is_false = assert =>
		assert.ErrMsg("Foo Error.", ()=> DieUnless(1 == 2, "Foo Error."));

	_ die_with = assert =>
		assert.Throws<NullReferenceException>(
				()=> DieWith<NullReferenceException>("Foo can't be null."));

	_ die_with_if_cond_is_true = assert =>
		assert.Throws<NullReferenceException>(()=> 
			DieWith<NullReferenceException>(If(1==1), "Foo can't be null."));

	_ dont_die_with_if_cond_is_false = assert => {
		DieWith<NullReferenceException>(If(1==2), "Foo can't be null.");
		assert.Pass();
	};

	_ die_with_unless_cond_is_true = assert =>
		assert.Throws<NullReferenceException>(()=> 
			DieWith<NullReferenceException>(Unless(1==2), "Foo can't be null."));
}
