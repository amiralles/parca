using System;

/// This class provides a handful of *die* helper methods.
public static class Parca {

	/// Throws and exception with the given message.
	public static void Die(string reason) { 
		throw new Exception(reason);
	}

	/// Throws and exception if the given codition is true.
	public static void DieIf(bool condition, string msg) {
		if (condition)
			Die(msg);
	}

	/// Throws and exception if the given codition is *NOT* true.
	public static void DieUnless(bool condition, string msg) =>
		DieIf(!condition, msg);	

	/// Throws and exception of the given &amp;T&amp; type.
	public static void DieWith<T>(string reason) where T : Exception {
		var ex = Activator.CreateInstance(typeof(T), true);
		throw (Exception)ex;
	}

	/// Throws and exception of the given &amp;T&amp; type if the given
	/// condition is true.
	public static void DieWith<T>(bool condition, string msg) 
		where T : Exception {
			if (condition)
				DieWith<T>(msg);
	}


	// Syntax sugar to emulate and *if* expression.
	// i.e. DieWith<ApplicationException>(If(someCondition), "Some message.");
	public static bool If(bool condition) => condition;

	// Syntax sugar to emulate and *if NOT* expression.
	public static bool Unless(bool condition) => !condition;
}
