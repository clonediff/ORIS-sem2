using dogsAPI.Models;

namespace dogsAPI.Data
{
	public static class DataSeeds
	{
		public static List<Dog> Dogs = new()
		{
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Affenpinscher",
				Weight = new()
				{
					Imperial = new(6, 13),
					Metric = new(3, 6)
				},
				Height = new()
				{
					Imperial = new(9, 11.5),
					Metric = new(23, 29)
				},
				LifeSpan = new(10, 12),
				ImageUrl = "https://cdn2.thedogapi.com/images/BJa4kxc4X.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Afghan Hound",
				Weight = new()
				{
					Imperial = new(50, 60),
					Metric = new(23, 27)
				},
				Height = new()
				{
					Imperial = new(25, 27),
					Metric = new(64, 69)
				},
				LifeSpan = new(10, 13),
				ImageUrl = "https://cdn2.thedogapi.com/images/hMyT4CDXR.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "African Hunting Dog",
				Weight = new()
				{
					Imperial = new(44, 66),
					Metric = new(20, 30)
				},
				Height = new()
				{
					Imperial = new(30),
					Metric = new(76)
				},
				LifeSpan = new(11),
				ImageUrl = "https://cdn2.thedogapi.com/images/rkiByec47.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Airedale Terrier",
				Weight = new()
				{
					Imperial = new(40, 65),
					Metric = new(18, 29)
				},
				Height = new()
				{
					Imperial = new(21, 23),
					Metric = new(53, 58)
				},
				LifeSpan = new(10, 13),
				ImageUrl = "https://cdn2.thedogapi.com/images/1-7cgoZSh.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Akbash Dog",
				Weight = new()
				{
					Imperial = new(90, 120),
					Metric = new(41, 54)
				},
				Height = new()
				{
					Imperial = new(28, 34),
					Metric = new(71, 86)
				},
				LifeSpan = new(10, 12),
				ImageUrl = "https://cdn2.thedogapi.com/images/26pHT3Qk7.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Akita",
				Weight = new()
				{
					Imperial = new(65, 115),
					Metric = new(29, 52)
				},
				Height = new()
				{
					Imperial = new(24, 28),
					Metric = new(61, 71)
				},
				LifeSpan = new(10, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/BFRYBufpm.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Alapaha Blue Blood Bulldog",
				Weight = new()
				{
					Imperial = new(55, 90),
					Metric = new(25, 41)
				},
				Height = new()
				{
					Imperial = new(18, 24),
					Metric = new(46, 61)
				},
				LifeSpan = new(12, 13),
				ImageUrl = "https://cdn2.thedogapi.com/images/33mJ-V3RX.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Alaskan Husky",
				Weight = new()
				{
					Imperial = new(38, 50),
					Metric = new(17, 23)
				},
				Height = new()
				{
					Imperial = new(23, 26),
					Metric = new(58, 66)
				},
				LifeSpan = new(10, 13),
				ImageUrl = "https://cdn2.thedogapi.com/images/-HgpNnGXl.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Alaskan Malamute",
				Weight = new()
				{
					Imperial = new(65, 100),
					Metric = new(29, 45)
				},
				Height = new()
				{
					Imperial = new(23, 25),
					Metric = new(58, 64)
				},
				LifeSpan = new(12, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/dW5UucTIW.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "American Bulldog",
				Weight = new()
				{
					Imperial = new(60, 120),
					Metric = new(27, 54)
				},
				Height = new()
				{
					Imperial = new(22, 27),
					Metric = new(56, 69)
				},
				LifeSpan = new(10, 12),
				ImageUrl = "https://cdn2.thedogapi.com/images/pk1AAdloG.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "American Bully",
				Weight = new()
				{
					Imperial = new(30, 150),
					Metric = new(14, 68)
				},
				Height = new()
				{
					Imperial = new(14, 17),
					Metric = new(36, 43)
				},
				LifeSpan = new(8, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/sqQJDtbpY.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "American Eskimo Dog",
				Weight = new()
				{
					Imperial = new(20, 40),
					Metric = new(9, 18)
				},
				Height = new()
				{
					Imperial = new(15, 19),
					Metric = new(38, 48)
				},
				LifeSpan = new(12, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/Bymjyec4m.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "American Eskimo Dog (Miniature)",
				Weight = new()
				{
					Imperial = new(7, 10),
					Metric = new(3, 5)
				},
				Height = new()
				{
					Imperial = new(9, 12),
					Metric = new(23, 30)
				},
				LifeSpan = new(13, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/_gn8GLrE6.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "American Foxhound",
				Weight = new()
				{
					Imperial = new(65, 75),
					Metric = new(29, 34)
				},
				Height = new()
				{
					Imperial = new(21, 28),
					Metric = new(53, 71)
				},
				LifeSpan = new(8, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/S14n1x9NQ.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "American Pit Bull Terrier",
				Weight = new()
				{
					Imperial = new(30, 60),
					Metric = new(14, 27)
				},
				Height = new()
				{
					Imperial = new(17, 21),
					Metric = new(43, 53)
				},
				LifeSpan = new(10, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/HkC31gcNm.png"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "American Staffordshire Terrier",
				Weight = new()
				{
					Imperial = new(50, 60),
					Metric = new(23, 27)
				},
				Height = new()
				{
					Imperial = new(17, 19),
					Metric = new(43, 48)
				},
				LifeSpan = new(12, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/rJIakgc4m.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "American Water Spaniel",
				Weight = new()
				{
					Imperial = new(25, 45),
					Metric = new(11, 20)
				},
				Height = new()
				{
					Imperial = new(15, 18),
					Metric = new(38, 46)
				},
				LifeSpan = new(10, 12),
				ImageUrl = "https://cdn2.thedogapi.com/images/SkmRJl9VQ.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Anatolian Shepherd Dog",
				Weight = new()
				{
					Imperial = new(80, 150),
					Metric = new(36, 68)
				},
				Height = new()
				{
					Imperial = new(27, 29),
					Metric = new(69, 74)
				},
				LifeSpan = new(11, 13),
				ImageUrl = "https://cdn2.thedogapi.com/images/BJT0Jx5Nm.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Appenzeller Sennenhund",
				Weight = new()
				{
					Imperial = new(48, 55),
					Metric = new(22, 25)
				},
				Height = new()
				{
					Imperial = new(20, 22),
					Metric = new(51, 56)
				},
				LifeSpan = new(12, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/HkNkxlqEX.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Australian Cattle Dog",
				Weight = new()
				{
					Imperial = new(44, 62),
					Metric = new(20, 28)
				},
				Height = new()
				{
					Imperial = new(17, 20),
					Metric = new(43, 51)
				},
				LifeSpan = new(12, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/IBkYVm4v1.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Australian Kelpie",
				Weight = new()
				{
					Imperial = new(31, 46),
					Metric = new(14, 21)
				},
				Height = new()
				{
					Imperial = new(17, 20),
					Metric = new(43, 51)
				},
				LifeSpan = new(10, 13),
				ImageUrl = "https://cdn2.thedogapi.com/images/Hyq1ge9VQ.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Australian Shepherd",
				Weight = new()
				{
					Imperial = new(35, 65),
					Metric = new(16, 29)
				},
				Height = new()
				{
					Imperial = new(18, 23),
					Metric = new(46, 58)
				},
				LifeSpan = new(12, 16),
				ImageUrl = "https://cdn2.thedogapi.com/images/B1-llgq4m.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Australian Terrier",
				Weight = new()
				{
					Imperial = new(14, 16),
					Metric = new(6, 7)
				},
				Height = new()
				{
					Imperial = new(10, 11),
					Metric = new(25, 28)
				},
				LifeSpan = new(15),
				ImageUrl = "https://cdn2.thedogapi.com/images/r1Ylge5Vm.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Azawakh",
				Weight = new()
				{
					Imperial = new(33, 55),
					Metric = new(15, 25)
				},
				Height = new()
				{
					Imperial = new(23, 29),
					Metric = new(58, 74)
				},
				LifeSpan = new(10, 13),
				ImageUrl = "https://cdn2.thedogapi.com/images/SkvZgx94m.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Barbet",
				Weight = new()
				{
					Imperial = new(40, 65),
					Metric = new(18, 29)
				},
				Height = new()
				{
					Imperial = new(20, 26),
					Metric = new(51, 66)
				},
				LifeSpan = new(13, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/HyWGexcVQ.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Basenji",
				Weight = new()
				{
					Imperial = new(22, 24),
					Metric = new(10, 11)
				},
				Height = new()
				{
					Imperial = new(16, 17),
					Metric = new(41, 43)
				},
				LifeSpan = new(10, 12),
				ImageUrl = "https://cdn2.thedogapi.com/images/H1dGlxqNQ.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Basset Bleu de Gascogne",
				Weight = new()
				{
					Imperial = new(35, 40),
					Metric = new(16, 18)
				},
				Height = new()
				{
					Imperial = new(13, 15),
					Metric = new(33, 38)
				},
				LifeSpan = new(10, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/BkMQll94X.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Basset Hound",
				Weight = new()
				{
					Imperial = new(50, 65),
					Metric = new(23, 29)
				},
				Height = new()
				{
					Imperial = new(14),
					Metric = new(36)
				},
				LifeSpan = new(12, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/Sy57xx9EX.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Beagle",
				Weight = new()
				{
					Imperial = new(20, 35),
					Metric = new(9, 16)
				},
				Height = new()
				{
					Imperial = new(13, 15),
					Metric = new(33, 38)
				},
				LifeSpan = new(13, 16),
				ImageUrl = "https://cdn2.thedogapi.com/images/Syd4xxqEm.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Bearded Collie",
				Weight = new()
				{
					Imperial = new(45, 55),
					Metric = new(20, 25)
				},
				Height = new()
				{
					Imperial = new(20, 22),
					Metric = new(51, 56)
				},
				LifeSpan = new(12, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/A09F4c1qP.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Beauceron",
				Weight = new()
				{
					Imperial = new(80, 110),
					Metric = new(36, 50)
				},
				Height = new()
				{
					Imperial = new(24, 27.5),
					Metric = new(61, 70)
				},
				LifeSpan = new(10, 12),
				ImageUrl = "https://cdn2.thedogapi.com/images/HJQ8ge5V7.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Bedlington Terrier",
				Weight = new()
				{
					Imperial = new(17, 23),
					Metric = new(8, 10)
				},
				Height = new()
				{
					Imperial = new(15, 16),
					Metric = new(38, 41)
				},
				LifeSpan = new(14, 16),
				ImageUrl = "https://cdn2.thedogapi.com/images/ByK8gx947.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Belgian Malinois",
				Weight = new()
				{
					Imperial = new(40, 80),
					Metric = new(18, 36)
				},
				Height = new()
				{
					Imperial = new(22, 26),
					Metric = new(56, 66)
				},
				LifeSpan = new(12, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/r1f_ll5VX.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Belgian Tervuren",
				Weight = new()
				{
					Imperial = new(40, 65),
					Metric = new(18, 29)
				},
				Height = new()
				{
					Imperial = new(22, 26),
					Metric = new(56, 66)
				},
				LifeSpan = new(10, 12),
				ImageUrl = "https://cdn2.thedogapi.com/images/B1KdxlcNX.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Bernese Mountain Dog",
				Weight = new()
				{
					Imperial = new(65, 120),
					Metric = new(29, 54)
				},
				Height = new()
				{
					Imperial = new(23, 27.5),
					Metric = new(58, 70)
				},
				LifeSpan = new(7, 10),
				ImageUrl = "https://cdn2.thedogapi.com/images/S1fFlx5Em.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Bichon Frise",
				Weight = new()
				{
					Imperial = new(10, 18),
					Metric = new(5, 8)
				},
				Height = new()
				{
					Imperial = new(9.5, 11.5),
					Metric = new(24, 29)
				},
				LifeSpan = new(15),
				ImageUrl = "https://cdn2.thedogapi.com/images/HkuYlxqEQ.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Black and Tan Coonhound",
				Weight = new()
				{
					Imperial = new(65, 100),
					Metric = new(29, 45)
				},
				Height = new()
				{
					Imperial = new(23, 27),
					Metric = new(58, 69)
				},
				LifeSpan = new(10, 12),
				ImageUrl = "https://cdn2.thedogapi.com/images/HJAFgxcNQ.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Bloodhound",
				Weight = new()
				{
					Imperial = new(80, 110),
					Metric = new(36, 50)
				},
				Height = new()
				{
					Imperial = new(23, 27),
					Metric = new(58, 69)
				},
				LifeSpan = new(8, 10),
				ImageUrl = "https://cdn2.thedogapi.com/images/Skdcgx9VX.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Bluetick Coonhound",
				Weight = new()
				{
					Imperial = new(45, 80),
					Metric = new(20, 36)
				},
				Height = new()
				{
					Imperial = new(21, 27),
					Metric = new(53, 69)
				},
				LifeSpan = new(12, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/rJxieg9VQ.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Boerboel",
				Weight = new()
				{
					Imperial = new(110, 200),
					Metric = new(50, 91)
				},
				Height = new()
				{
					Imperial = new(22, 27),
					Metric = new(56, 69)
				},
				LifeSpan = new(10, 12),
				ImageUrl = "https://cdn2.thedogapi.com/images/HyOjge5Vm.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Border Collie",
				Weight = new()
				{
					Imperial = new(30, 45),
					Metric = new(14, 20)
				},
				Height = new()
				{
					Imperial = new(18, 22),
					Metric = new(46, 56)
				},
				LifeSpan = new(12, 16),
				ImageUrl = "https://cdn2.thedogapi.com/images/sGQvQUpsp.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Border Terrier",
				Weight = new()
				{
					Imperial = new(11.5, 15.5),
					Metric = new(5, 7)
				},
				Height = new()
				{
					Imperial = new(11, 16),
					Metric = new(28, 41)
				},
				LifeSpan = new(12, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/HJOpge9Em.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Boston Terrier",
				Weight = new()
				{
					Imperial = new(10, 25),
					Metric = new(5, 11)
				},
				Height = new()
				{
					Imperial = new(16, 17),
					Metric = new(41, 43)
				},
				LifeSpan = new(11, 13),
				ImageUrl = "https://cdn2.thedogapi.com/images/rkZRggqVX.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Bouvier des Flandres",
				Weight = new()
				{
					Imperial = new(70, 110),
					Metric = new(32, 50)
				},
				Height = new()
				{
					Imperial = new(23.5, 27.5),
					Metric = new(60, 70)
				},
				LifeSpan = new(10, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/Byd0xl5VX.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Boxer",
				Weight = new()
				{
					Imperial = new(50, 70),
					Metric = new(23, 32)
				},
				Height = new()
				{
					Imperial = new(21.5, 25),
					Metric = new(55, 64)
				},
				LifeSpan = new(8, 10),
				ImageUrl = "https://cdn2.thedogapi.com/images/ry1kWe5VQ.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Boykin Spaniel",
				Weight = new()
				{
					Imperial = new(25, 40),
					Metric = new(11, 18)
				},
				Height = new()
				{
					Imperial = new(14, 18),
					Metric = new(36, 46)
				},
				LifeSpan = new(10, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/ryHJZlcNX.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Bracco Italiano",
				Weight = new()
				{
					Imperial = new(55, 88),
					Metric = new(25, 40)
				},
				Height = new()
				{
					Imperial = new(21.5, 26.5),
					Metric = new(55, 67)
				},
				LifeSpan = new(10, 12),
				ImageUrl = "https://cdn2.thedogapi.com/images/S13yZg5VQ.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Briard",
				Weight = new()
				{
					Imperial = new(70, 90),
					Metric = new(32, 41)
				},
				Height = new()
				{
					Imperial = new(22, 27),
					Metric = new(56, 69)
				},
				LifeSpan = new(10, 12),
				ImageUrl = "https://cdn2.thedogapi.com/images/rkVlblcEQ.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Brittany",
				Weight = new()
				{
					Imperial = new(30, 45),
					Metric = new(14, 20)
				},
				Height = new()
				{
					Imperial = new(17.5, 20.5),
					Metric = new(44, 52)
				},
				LifeSpan = new(12, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/HJWZZxc4X.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Bull Terrier",
				Weight = new()
				{
					Imperial = new(50, 70),
					Metric = new(23, 32)
				},
				Height = new()
				{
					Imperial = new(21, 22),
					Metric = new(53, 56)
				},
				LifeSpan = new(10, 12),
				ImageUrl = "https://cdn2.thedogapi.com/images/VSraIEQGd.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Bull Terrier (Miniature)",
				Weight = new()
				{
					Imperial = new(25, 33),
					Metric = new(11, 15)
				},
				Height = new()
				{
					Imperial = new(10, 14),
					Metric = new(25, 36)
				},
				LifeSpan = new(11, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/BkKZWlcVX.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Bullmastiff",
				Weight = new()
				{
					Imperial = new(100, 130),
					Metric = new(45, 59)
				},
				Height = new()
				{
					Imperial = new(24, 27),
					Metric = new(61, 69)
				},
				LifeSpan = new(8, 12),
				ImageUrl = "https://cdn2.thedogapi.com/images/r1ifZl5E7.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Cairn Terrier",
				Weight = new()
				{
					Imperial = new(13, 14),
					Metric = new(6, 6)
				},
				Height = new()
				{
					Imperial = new(9, 10),
					Metric = new(23, 25)
				},
				LifeSpan = new(14, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/Sk7Qbg9E7.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Cane Corso",
				Weight = new()
				{
					Imperial = new(88, 120),
					Metric = new(40, 54)
				},
				Height = new()
				{
					Imperial = new(23.5, 27.5),
					Metric = new(60, 70)
				},
				LifeSpan = new(10, 11),
				ImageUrl = "https://cdn2.thedogapi.com/images/r15m-lc4m.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Cardigan Welsh Corgi",
				Weight = new()
				{
					Imperial = new(25, 38),
					Metric = new(11, 17)
				},
				Height = new()
				{
					Imperial = new(10.5, 12.5),
					Metric = new(27, 32)
				},
				LifeSpan = new(12, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/SyXN-e9NX.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Catahoula Leopard Dog",
				Weight = new()
				{
					Imperial = new(50, 95),
					Metric = new(23, 43)
				},
				Height = new()
				{
					Imperial = new(20, 26),
					Metric = new(51, 66)
				},
				LifeSpan = new(10, 12),
				ImageUrl = "https://cdn2.thedogapi.com/images/BJcNbec4X.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Caucasian Shepherd (Ovcharka)",
				Weight = new()
				{
					Imperial = new(80, 100),
					Metric = new(36, 45)
				},
				Height = new()
				{
					Imperial = new(24, 33.5),
					Metric = new(61, 85)
				},
				LifeSpan = new(10, 12),
				ImageUrl = "https://cdn2.thedogapi.com/images/r1rrWe5Em.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Cavalier King Charles Spaniel",
				Weight = new()
				{
					Imperial = new(13, 18),
					Metric = new(6, 8)
				},
				Height = new()
				{
					Imperial = new(12, 13),
					Metric = new(30, 33)
				},
				LifeSpan = new(10, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/HJRBbe94Q.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Chesapeake Bay Retriever",
				Weight = new()
				{
					Imperial = new(55, 80),
					Metric = new(25, 36)
				},
				Height = new()
				{
					Imperial = new(21, 26),
					Metric = new(53, 66)
				},
				LifeSpan = new(10, 13),
				ImageUrl = "https://cdn2.thedogapi.com/images/9BXwUeCc2.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Chinese Crested",
				Weight = new()
				{
					Imperial = new(10, 13),
					Metric = new(5, 6)
				},
				Height = new()
				{
					Imperial = new(11, 13),
					Metric = new(28, 33)
				},
				LifeSpan = new(10, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/B1pDZx9Nm.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Chinese Shar-Pei",
				Weight = new()
				{
					Imperial = new(45, 60),
					Metric = new(20, 27)
				},
				Height = new()
				{
					Imperial = new(18, 20),
					Metric = new(46, 51)
				},
				LifeSpan = new(10),
				ImageUrl = "https://cdn2.thedogapi.com/images/B1ruWl94Q.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Chinook",
				Weight = new()
				{
					Imperial = new(50, 90),
					Metric = new(23, 41)
				},
				Height = new()
				{
					Imperial = new(22, 26),
					Metric = new(56, 66)
				},
				LifeSpan = new(12, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/Sypubg54Q.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Chow Chow",
				Weight = new()
				{
					Imperial = new(40, 70),
					Metric = new(18, 32)
				},
				Height = new()
				{
					Imperial = new(17, 20),
					Metric = new(43, 51)
				},
				LifeSpan = new(12, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/ry8KWgqEQ.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Clumber Spaniel",
				Weight = new()
				{
					Imperial = new(55, 85),
					Metric = new(25, 39)
				},
				Height = new()
				{
					Imperial = new(17, 20),
					Metric = new(43, 51)
				},
				LifeSpan = new(10, 12),
				ImageUrl = "https://cdn2.thedogapi.com/images/rkeqWgq4Q.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Cocker Spaniel",
				Weight = new()
				{
					Imperial = new(20, 30),
					Metric = new(9, 14)
				},
				Height = new()
				{
					Imperial = new(14, 15),
					Metric = new(36, 38)
				},
				LifeSpan = new(12, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/1lFmrzECl.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Cocker Spaniel (American)",
				Weight = new()
				{
					Imperial = new(20, 30),
					Metric = new(9, 14)
				},
				Height = new()
				{
					Imperial = new(14, 15),
					Metric = new(36, 38)
				},
				LifeSpan = new(12, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/HkRcZe547.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Coton de Tulear",
				Weight = new()
				{
					Imperial = new(9, 15),
					Metric = new(4, 7)
				},
				Height = new()
				{
					Imperial = new(9, 11),
					Metric = new(23, 28)
				},
				LifeSpan = new(13, 16),
				ImageUrl = "https://cdn2.thedogapi.com/images/SyviZlqNm.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Dalmatian",
				Weight = new()
				{
					Imperial = new(50, 55),
					Metric = new(23, 25)
				},
				Height = new()
				{
					Imperial = new(19, 23),
					Metric = new(48, 58)
				},
				LifeSpan = new(10, 13),
				ImageUrl = "https://cdn2.thedogapi.com/images/SkJ3blcN7.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Doberman Pinscher",
				Weight = new()
				{
					Imperial = new(66, 88),
					Metric = new(30, 40)
				},
				Height = new()
				{
					Imperial = new(24, 28),
					Metric = new(61, 71)
				},
				LifeSpan = new(10),
				ImageUrl = "https://cdn2.thedogapi.com/images/HyL3bl94Q.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Dogo Argentino",
				Weight = new()
				{
					Imperial = new(80, 100),
					Metric = new(36, 45)
				},
				Height = new()
				{
					Imperial = new(23.5, 27),
					Metric = new(60, 69)
				},
				LifeSpan = new(10, 12),
				ImageUrl = "https://cdn2.thedogapi.com/images/S1nhWx94Q.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Dutch Shepherd",
				Weight = new()
				{
					Imperial = new(50, 70),
					Metric = new(23, 32)
				},
				Height = new()
				{
					Imperial = new(22, 24.5),
					Metric = new(56, 62)
				},
				LifeSpan = new(15),
				ImageUrl = "https://cdn2.thedogapi.com/images/BkE6Wg5E7.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "English Setter",
				Weight = new()
				{
					Imperial = new(45, 80),
					Metric = new(20, 36)
				},
				Height = new()
				{
					Imperial = new(24, 25),
					Metric = new(61, 64)
				},
				LifeSpan = new(12),
				ImageUrl = "https://cdn2.thedogapi.com/images/By4A-eqVX.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "English Shepherd",
				Weight = new()
				{
					Imperial = new(44, 66),
					Metric = new(20, 30)
				},
				Height = new()
				{
					Imperial = new(18, 23),
					Metric = new(46, 58)
				},
				LifeSpan = new(10, 13),
				ImageUrl = "https://cdn2.thedogapi.com/images/H1QyMe5EQ.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "English Springer Spaniel",
				Weight = new()
				{
					Imperial = new(35, 50),
					Metric = new(16, 23)
				},
				Height = new()
				{
					Imperial = new(19, 20),
					Metric = new(48, 51)
				},
				LifeSpan = new(12, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/Hk0Jfe5VQ.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "English Toy Spaniel",
				Weight = new()
				{
					Imperial = new(8, 14),
					Metric = new(4, 6)
				},
				Height = new()
				{
					Imperial = new(10),
					Metric = new(25)
				},
				LifeSpan = new(10, 12),
				ImageUrl = "https://cdn2.thedogapi.com/images/SkIgzxqNQ.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "English Toy Terrier",
				Weight = new()
				{
					Imperial = new(6, 8),
					Metric = new(3, 4)
				},
				Height = new()
				{
					Imperial = new(10, 12),
					Metric = new(25, 30)
				},
				LifeSpan = new(12, 13),
				ImageUrl = "https://cdn2.thedogapi.com/images/SJ6eMxqEQ.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Eurasier",
				Weight = new()
				{
					Imperial = new(40, 70),
					Metric = new(18, 32)
				},
				Height = new()
				{
					Imperial = new(20.5, 23.5),
					Metric = new(52, 60)
				},
				LifeSpan = new(12, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/S1VWGx9Nm.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Field Spaniel",
				Weight = new()
				{
					Imperial = new(35, 50),
					Metric = new(16, 23)
				},
				Height = new()
				{
					Imperial = new(17, 18),
					Metric = new(43, 46)
				},
				LifeSpan = new(11, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/SkJfGecE7.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Finnish Lapphund",
				Weight = new()
				{
					Imperial = new(33, 53),
					Metric = new(15, 24)
				},
				Height = new()
				{
					Imperial = new(16, 21),
					Metric = new(41, 53)
				},
				LifeSpan = new(12, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/S1KMGg5Vm.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Finnish Spitz",
				Weight = new()
				{
					Imperial = new(23, 28),
					Metric = new(10, 13)
				},
				Height = new()
				{
					Imperial = new(15.5, 20),
					Metric = new(39, 51)
				},
				LifeSpan = new(12, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/3PjHlQbkV.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "French Bulldog",
				Weight = new()
				{
					Imperial = new(28),
					Metric = new(13)
				},
				Height = new()
				{
					Imperial = new(11, 12),
					Metric = new(28, 30)
				},
				LifeSpan = new(9, 11),
				ImageUrl = "https://cdn2.thedogapi.com/images/HyWNfxc47.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "German Pinscher",
				Weight = new()
				{
					Imperial = new(25, 45),
					Metric = new(11, 20)
				},
				Height = new()
				{
					Imperial = new(17, 20),
					Metric = new(43, 51)
				},
				LifeSpan = new(12, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/B1u4zgqE7.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "German Shepherd Dog",
				Weight = new()
				{
					Imperial = new(50, 90),
					Metric = new(23, 41)
				},
				Height = new()
				{
					Imperial = new(22, 26),
					Metric = new(56, 66)
				},
				LifeSpan = new(10, 13),
				ImageUrl = "https://cdn2.thedogapi.com/images/SJyBfg5NX.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "German Shorthaired Pointer",
				Weight = new()
				{
					Imperial = new(45, 70),
					Metric = new(20, 32)
				},
				Height = new()
				{
					Imperial = new(21, 25),
					Metric = new(53, 64)
				},
				LifeSpan = new(12, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/SJqBMg5Nm.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Giant Schnauzer",
				Weight = new()
				{
					Imperial = new(65, 90),
					Metric = new(29, 41)
				},
				Height = new()
				{
					Imperial = new(23.5, 27.5),
					Metric = new(60, 70)
				},
				LifeSpan = new(10, 12),
				ImageUrl = "https://cdn2.thedogapi.com/images/H1NIzlcV7.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Glen of Imaal Terrier",
				Weight = new()
				{
					Imperial = new(32, 40),
					Metric = new(15, 18)
				},
				Height = new()
				{
					Imperial = new(12.5, 14),
					Metric = new(32, 36)
				},
				LifeSpan = new(12, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/H1oLMe94m.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Golden Retriever",
				Weight = new()
				{
					Imperial = new(55, 75),
					Metric = new(25, 34)
				},
				Height = new()
				{
					Imperial = new(21.5, 24),
					Metric = new(55, 61)
				},
				LifeSpan = new(10, 12),
				ImageUrl = "https://cdn2.thedogapi.com/images/HJ7Pzg5EQ.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Gordon Setter",
				Weight = new()
				{
					Imperial = new(45, 80),
					Metric = new(20, 36)
				},
				Height = new()
				{
					Imperial = new(23, 27),
					Metric = new(58, 69)
				},
				LifeSpan = new(10, 12),
				ImageUrl = "https://cdn2.thedogapi.com/images/SJ5vzx5NX.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Great Dane",
				Weight = new()
				{
					Imperial = new(110, 190),
					Metric = new(50, 86)
				},
				Height = new()
				{
					Imperial = new(28, 32),
					Metric = new(71, 81)
				},
				LifeSpan = new(7, 10),
				ImageUrl = "https://cdn2.thedogapi.com/images/B1Edfl9NX.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Great Pyrenees",
				Weight = new()
				{
					Imperial = new(85, 115),
					Metric = new(39, 52)
				},
				Height = new()
				{
					Imperial = new(25, 32),
					Metric = new(64, 81)
				},
				LifeSpan = new(10, 12),
				ImageUrl = "https://cdn2.thedogapi.com/images/B12uzg9V7.png"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Greyhound",
				Weight = new()
				{
					Imperial = new(50, 70),
					Metric = new(23, 32)
				},
				Height = new()
				{
					Imperial = new(27, 30),
					Metric = new(69, 76)
				},
				LifeSpan = new(10, 13),
				ImageUrl = "https://cdn2.thedogapi.com/images/ryNYMx94X.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Griffon Bruxellois",
				Weight = new()
				{
					Imperial = new(12),
					Metric = new(5)
				},
				Height = new()
				{
					Imperial = new(9, 11),
					Metric = new(23, 28)
				},
				LifeSpan = new(10, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/ryoYGec4Q.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Harrier",
				Weight = new()
				{
					Imperial = new(40, 60),
					Metric = new(18, 27)
				},
				Height = new()
				{
					Imperial = new(18, 22),
					Metric = new(46, 56)
				},
				LifeSpan = new(12, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/B1IcfgqE7.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Havanese",
				Weight = new()
				{
					Imperial = new(7, 13),
					Metric = new(3, 6)
				},
				Height = new()
				{
					Imperial = new(8.5, 11.5),
					Metric = new(22, 29)
				},
				LifeSpan = new(14, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/rkXiGl9V7.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Irish Setter",
				Weight = new()
				{
					Imperial = new(35, 70),
					Metric = new(16, 32)
				},
				Height = new()
				{
					Imperial = new(24, 27),
					Metric = new(61, 69)
				},
				LifeSpan = new(10, 11),
				ImageUrl = "https://cdn2.thedogapi.com/images/S1osGeqVm.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Irish Terrier",
				Weight = new()
				{
					Imperial = new(25, 27),
					Metric = new(11, 12)
				},
				Height = new()
				{
					Imperial = new(18),
					Metric = new(46)
				},
				LifeSpan = new(12, 16),
				ImageUrl = "https://cdn2.thedogapi.com/images/By-hGecVX.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Irish Wolfhound",
				Weight = new()
				{
					Imperial = new(105, 180),
					Metric = new(48, 82)
				},
				Height = new()
				{
					Imperial = new(30, 35),
					Metric = new(76, 89)
				},
				LifeSpan = new(6, 8),
				ImageUrl = "https://cdn2.thedogapi.com/images/Hyd2zgcEX.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Italian Greyhound",
				Weight = new()
				{
					Imperial = new(7, 15),
					Metric = new(3, 7)
				},
				Height = new()
				{
					Imperial = new(13, 15),
					Metric = new(33, 38)
				},
				LifeSpan = new(12, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/SJAnzg9NX.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Japanese Chin",
				Weight = new()
				{
					Imperial = new(4, 9),
					Metric = new(2, 4)
				},
				Height = new()
				{
					Imperial = new(8, 11),
					Metric = new(20, 28)
				},
				LifeSpan = new(12, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/r1H6feqEm.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Japanese Spitz",
				Weight = new()
				{
					Imperial = new(15, 19),
					Metric = new(7, 9)
				},
				Height = new()
				{
					Imperial = new(12, 15),
					Metric = new(30, 38)
				},
				LifeSpan = new(10, 16),
				ImageUrl = "https://cdn2.thedogapi.com/images/HksaMxqNX.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Keeshond",
				Weight = new()
				{
					Imperial = new(35, 45),
					Metric = new(16, 20)
				},
				Height = new()
				{
					Imperial = new(17, 18),
					Metric = new(43, 46)
				},
				LifeSpan = new(12, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/S1GAGg9Vm.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Komondor",
				Weight = new()
				{
					Imperial = new(80, 100),
					Metric = new(36, 45)
				},
				Height = new()
				{
					Imperial = new(25.5, 27.5),
					Metric = new(65, 70)
				},
				LifeSpan = new(10, 12),
				ImageUrl = "https://cdn2.thedogapi.com/images/Bko0fl547.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Kooikerhondje",
				Weight = new()
				{
					Imperial = new(20, 30),
					Metric = new(9, 14)
				},
				Height = new()
				{
					Imperial = new(14, 16),
					Metric = new(36, 41)
				},
				LifeSpan = new(12, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/kOMy84GQE.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Kuvasz",
				Weight = new()
				{
					Imperial = new(70, 115),
					Metric = new(32, 52)
				},
				Height = new()
				{
					Imperial = new(26, 30),
					Metric = new(66, 76)
				},
				LifeSpan = new(8, 10),
				ImageUrl = "https://cdn2.thedogapi.com/images/BykZ7ecVX.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Labrador Retriever",
				Weight = new()
				{
					Imperial = new(55, 80),
					Metric = new(25, 36)
				},
				Height = new()
				{
					Imperial = new(21.5, 24.5),
					Metric = new(55, 62)
				},
				LifeSpan = new(10, 13),
				ImageUrl = "https://cdn2.thedogapi.com/images/B1uW7l5VX.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Lagotto Romagnolo",
				Weight = new()
				{
					Imperial = new(24, 35),
					Metric = new(11, 16)
				},
				Height = new()
				{
					Imperial = new(16, 19),
					Metric = new(41, 48)
				},
				LifeSpan = new(14, 16),
				ImageUrl = "https://cdn2.thedogapi.com/images/ryzzmgqE7.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Lancashire Heeler",
				Weight = new()
				{
					Imperial = new(6, 13),
					Metric = new(3, 6)
				},
				Height = new()
				{
					Imperial = new(10, 12),
					Metric = new(25, 30)
				},
				LifeSpan = new(12, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/S1RGml5Em.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Leonberger",
				Weight = new()
				{
					Imperial = new(120, 170),
					Metric = new(54, 77)
				},
				Height = new()
				{
					Imperial = new(25.5, 31.5),
					Metric = new(65, 80)
				},
				LifeSpan = new(6, 8),
				ImageUrl = "https://cdn2.thedogapi.com/images/ByrmQlqVm.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Lhasa Apso",
				Weight = new()
				{
					Imperial = new(12, 18),
					Metric = new(5, 8)
				},
				Height = new()
				{
					Imperial = new(10, 11),
					Metric = new(25, 28)
				},
				LifeSpan = new(12, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/SJp7Qe5EX.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Maltese",
				Weight = new()
				{
					Imperial = new(4, 7),
					Metric = new(2, 3)
				},
				Height = new()
				{
					Imperial = new(8, 10),
					Metric = new(20, 25)
				},
				LifeSpan = new(15, 18),
				ImageUrl = "https://cdn2.thedogapi.com/images/B1SV7gqN7.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Miniature American Shepherd",
				Weight = new()
				{
					Imperial = new(20, 40),
					Metric = new(9, 18)
				},
				Height = new()
				{
					Imperial = new(13, 18),
					Metric = new(33, 46)
				},
				LifeSpan = new(12, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/BkHHQgcN7.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Miniature Pinscher",
				Weight = new()
				{
					Imperial = new(8, 11),
					Metric = new(4, 5)
				},
				Height = new()
				{
					Imperial = new(10, 12.5),
					Metric = new(25, 32)
				},
				LifeSpan = new(15),
				ImageUrl = "https://cdn2.thedogapi.com/images/Hy3H7g94X.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Miniature Schnauzer",
				Weight = new()
				{
					Imperial = new(11, 20),
					Metric = new(5, 9)
				},
				Height = new()
				{
					Imperial = new(12, 14),
					Metric = new(30, 36)
				},
				LifeSpan = new(12, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/SJIUQl9NX.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Newfoundland",
				Weight = new()
				{
					Imperial = new(100, 150),
					Metric = new(45, 68)
				},
				Height = new()
				{
					Imperial = new(26, 28),
					Metric = new(66, 71)
				},
				LifeSpan = new(8, 10),
				ImageUrl = "https://cdn2.thedogapi.com/images/Sk4DXl54m.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Norfolk Terrier",
				Weight = new()
				{
					Imperial = new(11, 12),
					Metric = new(5, 5)
				},
				Height = new()
				{
					Imperial = new(9, 10),
					Metric = new(23, 25)
				},
				LifeSpan = new(12, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/B1ADQg94X.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Norwich Terrier",
				Weight = new()
				{
					Imperial = new(11, 12),
					Metric = new(5, 5)
				},
				Height = new()
				{
					Imperial = new(10),
					Metric = new(25)
				},
				LifeSpan = new(12, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/BkgKXlqE7.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Nova Scotia Duck Tolling Retriever",
				Weight = new()
				{
					Imperial = new(35, 50),
					Metric = new(16, 23)
				},
				Height = new()
				{
					Imperial = new(17, 21),
					Metric = new(43, 53)
				},
				LifeSpan = new(12, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/SyYtQe5V7.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Old English Sheepdog",
				Weight = new()
				{
					Imperial = new(60, 100),
					Metric = new(27, 45)
				},
				Height = new()
				{
					Imperial = new(21),
					Metric = new(53)
				},
				LifeSpan = new(10, 12),
				ImageUrl = "https://cdn2.thedogapi.com/images/HkZ57lq4m.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Olde English Bulldogge",
				Weight = new()
				{
					Imperial = new(65, 85),
					Metric = new()
				},
				Height = new()
				{
					Imperial = new(15, 19),
					Metric = new(38, 48)
				},
				LifeSpan = new(9, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/B1d5me547.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Papillon",
				Weight = new()
				{
					Imperial = new(3, 12),
					Metric = new(1, 5)
				},
				Height = new()
				{
					Imperial = new(8, 11),
					Metric = new(20, 28)
				},
				LifeSpan = new(13, 17),
				ImageUrl = "https://cdn2.thedogapi.com/images/SkJj7e547.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Pekingese",
				Weight = new()
				{
					Imperial = new(14),
					Metric = new(6)
				},
				Height = new()
				{
					Imperial = new(6, 9),
					Metric = new(15, 23)
				},
				LifeSpan = new(14, 18),
				ImageUrl = "https://cdn2.thedogapi.com/images/ByIiml9Nm.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Pembroke Welsh Corgi",
				Weight = new()
				{
					Imperial = new(25, 30),
					Metric = new(11, 14)
				},
				Height = new()
				{
					Imperial = new(10, 12),
					Metric = new(25, 30)
				},
				LifeSpan = new(12, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/rJ6iQeqEm.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Perro de Presa Canario",
				Weight = new()
				{
					Imperial = new(88, 110),
					Metric = new(40, 50)
				},
				Height = new()
				{
					Imperial = new(22, 25.5),
					Metric = new(56, 65)
				},
				LifeSpan = new(10, 12),
				ImageUrl = "https://cdn2.thedogapi.com/images/S1V3Qeq4X.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Pharaoh Hound",
				Weight = new()
				{
					Imperial = new(40, 60),
					Metric = new(18, 27)
				},
				Height = new()
				{
					Imperial = new(21, 25),
					Metric = new(53, 64)
				},
				LifeSpan = new(12, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/Byz6mgqEQ.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Plott",
				Weight = new()
				{
					Imperial = new(40, 60),
					Metric = new(18, 27)
				},
				Height = new()
				{
					Imperial = new(20, 25),
					Metric = new(51, 64)
				},
				LifeSpan = new(12, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/B1i67l5VQ.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Pomeranian",
				Weight = new()
				{
					Imperial = new(3, 7),
					Metric = new(1, 3)
				},
				Height = new()
				{
					Imperial = new(8, 12),
					Metric = new(20, 30)
				},
				LifeSpan = new(15),
				ImageUrl = "https://cdn2.thedogapi.com/images/HJd0XecNX.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Poodle (Miniature)",
				Weight = new()
				{
					Imperial = new(15, 17),
					Metric = new(7, 8)
				},
				Height = new()
				{
					Imperial = new(11, 15),
					Metric = new(28, 38)
				},
				LifeSpan = new(12, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/Hkxk4ecVX.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Poodle (Toy)",
				Weight = new()
				{
					Imperial = new(6, 9),
					Metric = new(3, 4)
				},
				Height = new()
				{
					Imperial = new(9, 11),
					Metric = new(23, 28)
				},
				LifeSpan = new(18),
				ImageUrl = "https://cdn2.thedogapi.com/images/rJFJVxc4m.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Pug",
				Weight = new()
				{
					Imperial = new(14, 18),
					Metric = new(6, 8)
				},
				Height = new()
				{
					Imperial = new(10, 12),
					Metric = new(25, 30)
				},
				LifeSpan = new(12, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/HyJvcl9N7.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Puli",
				Weight = new()
				{
					Imperial = new(25, 35),
					Metric = new(11, 16)
				},
				Height = new()
				{
					Imperial = new(16, 17),
					Metric = new(41, 43)
				},
				LifeSpan = new(12, 16),
				ImageUrl = "https://cdn2.thedogapi.com/images/ryPgVl5N7.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Pumi",
				Weight = new()
				{
					Imperial = new(18, 33),
					Metric = new(8, 15)
				},
				Height = new()
				{
					Imperial = new(15, 18.5),
					Metric = new(38, 47)
				},
				LifeSpan = new(13, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/SyRe4xcN7.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Rat Terrier",
				Weight = new()
				{
					Imperial = new(8, 25),
					Metric = new(4, 11)
				},
				Height = new()
				{
					Imperial = new(10, 13),
					Metric = new(25, 33)
				},
				LifeSpan = new(12, 18),
				ImageUrl = "https://cdn2.thedogapi.com/images/HkXWNl9E7.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Redbone Coonhound",
				Weight = new()
				{
					Imperial = new(45, 80),
					Metric = new(20, 36)
				},
				Height = new()
				{
					Imperial = new(21, 27),
					Metric = new(53, 69)
				},
				LifeSpan = new(10, 12),
				ImageUrl = "https://cdn2.thedogapi.com/images/HJMzEl5N7.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Rhodesian Ridgeback",
				Weight = new()
				{
					Imperial = new(75, 80),
					Metric = new(34, 36)
				},
				Height = new()
				{
					Imperial = new(24, 27),
					Metric = new(61, 69)
				},
				LifeSpan = new(10, 12),
				ImageUrl = "https://cdn2.thedogapi.com/images/By9zNgqE7.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Rottweiler",
				Weight = new()
				{
					Imperial = new(75, 110),
					Metric = new(34, 50)
				},
				Height = new()
				{
					Imperial = new(22, 27),
					Metric = new(56, 69)
				},
				LifeSpan = new(8, 10),
				ImageUrl = "https://cdn2.thedogapi.com/images/r1xXEgcNX.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Russian Toy",
				Weight = new()
				{
					Imperial = new(3, 6),
					Metric = new(1, 3)
				},
				Height = new()
				{
					Imperial = new(7.5, 10.5),
					Metric = new(19, 27)
				},
				LifeSpan = new(10, 12),
				ImageUrl = "https://cdn2.thedogapi.com/images/HkP7Vxc4Q.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Saint Bernard",
				Weight = new()
				{
					Imperial = new(130, 180),
					Metric = new(59, 82)
				},
				Height = new()
				{
					Imperial = new(25.5, 27.5),
					Metric = new(65, 70)
				},
				LifeSpan = new(7, 10),
				ImageUrl = "https://cdn2.thedogapi.com/images/_Qf9nfRzL.png"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Saluki",
				Weight = new()
				{
					Imperial = new(35, 65),
					Metric = new(16, 29)
				},
				Height = new()
				{
					Imperial = new(23, 28),
					Metric = new(58, 71)
				},
				LifeSpan = new(12, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/fjFIuehNo.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Samoyed",
				Weight = new()
				{
					Imperial = new(50, 60),
					Metric = new(23, 27)
				},
				Height = new()
				{
					Imperial = new(19, 23.5),
					Metric = new(48, 60)
				},
				LifeSpan = new(12, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/S1T8Ee9Nm.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Schipperke",
				Weight = new()
				{
					Imperial = new(10, 16),
					Metric = new(5, 7)
				},
				Height = new()
				{
					Imperial = new(10, 13),
					Metric = new(25, 33)
				},
				LifeSpan = new(13, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/SyBvVgc47.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Scottish Deerhound",
				Weight = new()
				{
					Imperial = new(70, 130),
					Metric = new(32, 59)
				},
				Height = new()
				{
					Imperial = new(28, 32),
					Metric = new(71, 81)
				},
				LifeSpan = new(8, 10),
				ImageUrl = "https://cdn2.thedogapi.com/images/SkNjqx9NQ.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Scottish Terrier",
				Weight = new()
				{
					Imperial = new(18, 22),
					Metric = new(8, 10)
				},
				Height = new()
				{
					Imperial = new(10),
					Metric = new(25)
				},
				LifeSpan = new(11, 13),
				ImageUrl = "https://cdn2.thedogapi.com/images/Bklnce5NX.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Shetland Sheepdog",
				Weight = new()
				{
					Imperial = new(30),
					Metric = new(14)
				},
				Height = new()
				{
					Imperial = new(13, 16),
					Metric = new(33, 41)
				},
				LifeSpan = new(12, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/rJa29l9E7.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Shiba Inu",
				Weight = new()
				{
					Imperial = new(17, 23),
					Metric = new(8, 10)
				},
				Height = new()
				{
					Imperial = new(13.5, 16.5),
					Metric = new(34, 42)
				},
				LifeSpan = new(12, 16),
				ImageUrl = "https://cdn2.thedogapi.com/images/Zn3IjPX3f.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Shih Tzu",
				Weight = new()
				{
					Imperial = new(9, 16),
					Metric = new(4, 7)
				},
				Height = new()
				{
					Imperial = new(8, 11),
					Metric = new(20, 28)
				},
				LifeSpan = new(10, 18),
				ImageUrl = "https://cdn2.thedogapi.com/images/BkrJjgcV7.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Shiloh Shepherd",
				Weight = new()
				{
					Imperial = new(120, 140),
					Metric = new(54, 64)
				},
				Height = new()
				{
					Imperial = new(26, 30),
					Metric = new(66, 76)
				},
				LifeSpan = new(9, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/SJJxjecEX.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Siberian Husky",
				Weight = new()
				{
					Imperial = new(35, 60),
					Metric = new(16, 27)
				},
				Height = new()
				{
					Imperial = new(20, 23.5),
					Metric = new(51, 60)
				},
				LifeSpan = new(12),
				ImageUrl = "https://cdn2.thedogapi.com/images/S17ZilqNm.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Silky Terrier",
				Weight = new()
				{
					Imperial = new(8, 10),
					Metric = new(4, 5)
				},
				Height = new()
				{
					Imperial = new(9, 10),
					Metric = new(23, 25)
				},
				LifeSpan = new(12, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/ByzGsl5Nm.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Smooth Fox Terrier",
				Weight = new()
				{
					Imperial = new(18),
					Metric = new(8)
				},
				Height = new()
				{
					Imperial = new(15.5),
					Metric = new(39)
				},
				LifeSpan = new(12, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/Syszjx9Em.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Soft Coated Wheaten Terrier",
				Weight = new()
				{
					Imperial = new(30, 40),
					Metric = new(14, 18)
				},
				Height = new()
				{
					Imperial = new(16, 18),
					Metric = new(41, 46)
				},
				LifeSpan = new(12, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/HJHmix5NQ.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Spanish Water Dog",
				Weight = new()
				{
					Imperial = new(30, 50),
					Metric = new(14, 23)
				},
				Height = new()
				{
					Imperial = new(16, 20),
					Metric = new(41, 51)
				},
				LifeSpan = new(12, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/HJf4jl9VX.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Spinone Italiano",
				Weight = new()
				{
					Imperial = new(61, 85),
					Metric = new(28, 39)
				},
				Height = new()
				{
					Imperial = new(22.5, 27.5),
					Metric = new(57, 70)
				},
				LifeSpan = new(10, 12),
				ImageUrl = "https://cdn2.thedogapi.com/images/rk5Eoe5Nm.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Staffordshire Bull Terrier",
				Weight = new()
				{
					Imperial = new(24, 38),
					Metric = new(11, 17)
				},
				Height = new()
				{
					Imperial = new(14, 16),
					Metric = new(36, 41)
				},
				LifeSpan = new(12, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/H1zSie9V7.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Standard Schnauzer",
				Weight = new()
				{
					Imperial = new(30, 50),
					Metric = new(14, 23)
				},
				Height = new()
				{
					Imperial = new(17.5, 19.5),
					Metric = new(44, 50)
				},
				LifeSpan = new(13, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/tmzeu6ID_.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Swedish Vallhund",
				Weight = new()
				{
					Imperial = new(20, 30),
					Metric = new(9, 14)
				},
				Height = new()
				{
					Imperial = new(11.5, 13.5),
					Metric = new(29, 34)
				},
				LifeSpan = new(12, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/HJ-Dix94Q.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Thai Ridgeback",
				Weight = new()
				{
					Imperial = new(35, 55),
					Metric = new(16, 25)
				},
				Height = new()
				{
					Imperial = new(20, 24),
					Metric = new(51, 61)
				},
				LifeSpan = new(10, 12),
				ImageUrl = "https://cdn2.thedogapi.com/images/zv89hR-O8.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Tibetan Mastiff",
				Weight = new()
				{
					Imperial = new(85, 140),
					Metric = new(39, 64)
				},
				Height = new()
				{
					Imperial = new(24, 26),
					Metric = new(61, 66)
				},
				LifeSpan = new(10, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/SkM9sec47.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Tibetan Spaniel",
				Weight = new()
				{
					Imperial = new(9, 15),
					Metric = new(4, 7)
				},
				Height = new()
				{
					Imperial = new(10),
					Metric = new(25)
				},
				LifeSpan = new(12, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/Hyjcol947.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Tibetan Terrier",
				Weight = new()
				{
					Imperial = new(20, 24),
					Metric = new(9, 11)
				},
				Height = new()
				{
					Imperial = new(14, 17),
					Metric = new(36, 43)
				},
				LifeSpan = new(12, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/6f5n_42mB.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Toy Fox Terrier",
				Weight = new()
				{
					Imperial = new(4, 9),
					Metric = new(2, 4)
				},
				Height = new()
				{
					Imperial = new(8, 11),
					Metric = new(20, 28)
				},
				LifeSpan = new(12, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/B17ase9V7.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Treeing Walker Coonhound",
				Weight = new()
				{
					Imperial = new(45, 80),
					Metric = new(20, 36)
				},
				Height = new()
				{
					Imperial = new(20, 27),
					Metric = new(51, 69)
				},
				LifeSpan = new(10, 13),
				ImageUrl = "https://cdn2.thedogapi.com/images/SkRpsgc47.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Vizsla",
				Weight = new()
				{
					Imperial = new(50, 65),
					Metric = new(23, 29)
				},
				Height = new()
				{
					Imperial = new(21, 24),
					Metric = new(53, 61)
				},
				LifeSpan = new(10, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/r1o0jx9Em.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Weimaraner",
				Weight = new()
				{
					Imperial = new(55, 90),
					Metric = new(25, 41)
				},
				Height = new()
				{
					Imperial = new(23, 27),
					Metric = new(58, 69)
				},
				LifeSpan = new(12, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/SyU12l9V7.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Welsh Springer Spaniel",
				Weight = new()
				{
					Imperial = new(35, 55),
					Metric = new(16, 25)
				},
				Height = new()
				{
					Imperial = new(17, 19),
					Metric = new(43, 48)
				},
				LifeSpan = new(12, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/BJ1gnx5Vm.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "West Highland White Terrier",
				Weight = new()
				{
					Imperial = new(15, 22),
					Metric = new(7, 10)
				},
				Height = new()
				{
					Imperial = new(10, 11),
					Metric = new(25, 28)
				},
				LifeSpan = new(15, 20),
				ImageUrl = "https://cdn2.thedogapi.com/images/Bkdx2g5Em.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Whippet",
				Weight = new()
				{
					Imperial = new(25, 35),
					Metric = new(11, 16)
				},
				Height = new()
				{
					Imperial = new(18, 22),
					Metric = new(46, 56)
				},
				LifeSpan = new(12, 15),
				ImageUrl = "https://cdn2.thedogapi.com/images/Hyv-ne94m.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "White Shepherd",
				Weight = new()
				{
					Imperial = new(60, 85),
					Metric = new(27, 39)
				},
				Height = new()
				{
					Imperial = new(22, 25),
					Metric = new(56, 64)
				},
				LifeSpan = new(12, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/r14M3e9E7.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Wire Fox Terrier",
				Weight = new()
				{
					Imperial = new(15, 19),
					Metric = new(7, 9)
				},
				Height = new()
				{
					Imperial = new(13, 16),
					Metric = new(33, 41)
				},
				LifeSpan = new(13, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/SJ6f2g9EQ.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Wirehaired Pointing Griffon",
				Weight = new()
				{
					Imperial = new(45, 70),
					Metric = new(20, 32)
				},
				Height = new()
				{
					Imperial = new(20, 24),
					Metric = new(51, 61)
				},
				LifeSpan = new(12, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/Bkam2l9Vm.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Wirehaired Vizsla",
				Weight = new()
				{
					Imperial = new(45, 65),
					Metric = new(20, 29)
				},
				Height = new()
				{
					Imperial = new(21.5, 25),
					Metric = new(55, 64)
				},
				LifeSpan = new(12, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/r1I4hl5Em.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Xoloitzcuintli",
				Weight = new()
				{
					Imperial = new(9, 31),
					Metric = new(4, 14)
				},
				Height = new()
				{
					Imperial = new(10, 23),
					Metric = new(25, 58)
				},
				LifeSpan = new(12, 14),
				ImageUrl = "https://cdn2.thedogapi.com/images/HkNS3gqEm.jpg"
			},
			new Dog
			{
				Id = Guid.NewGuid(),
				Name = "Yorkshire Terrier",
				Weight = new()
				{
					Imperial = new(4, 7),
					Metric = new(2, 3)
				},
				Height = new()
				{
					Imperial = new(8, 9),
					Metric = new(20, 23)
				},
				LifeSpan = new(12, 16),
				ImageUrl = "https://cdn2.thedogapi.com/images/B12BnxcVQ.jpg"
			},
		};
	}
}
