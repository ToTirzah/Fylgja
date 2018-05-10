# Fylgja
Syntax sugar and language extensions for better experience with expression-bodied members.

Some examples:

	Right hand assigment with deconstruct option:
		sender.To(out Button b).DataContext.To(out IModel m).Update();

	Object initialization:
		var person = CreatePerson().To(out var p)?.With
		(
			p.ToString().To(out var personStringView)
		);

	Same goes for structs
		s.With(s.Name = "DefaultName").Put(ref s);

	Conditions:
		if (GetPerson() is Person p && p.Check
			(
				p.FirstName is "Keanu",
				p.LastName is string lastName,
				p.Age.To(out var age) > 23
			).All(true))

	Lambda-styled type matching:
		shape.Match
			(
				(Line _) => 0,
				(Circle c) => Math.PI * c.Radius * c.Radius,
				(Rectangle r) => r.Width * r.Height,
				() => double.NaN
			);

