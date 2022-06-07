module Data

open System

type Product =
    { Id: string
      Code: string
      Name: string
      Description: string
      Image: string
      Price: int
      Category: string
      Quantity: int
      InventoryStatus: string
      Rating: int }

type Country = { Name: string; Code: string }
type Representative = { Name: string; Image: string }

type Customer =
    { Id: int
      Name: string
      Country: Country
      Company: string
      Date: DateTime
      Status: string
      Verified: bool
      Activity: int
      Representative: Representative
      Balance: int }

let customers =
    [ { Id = 1000
        Name = "James Butt"
        Country = { Name = "Algeria"; Code = "dz" }
        Company = "Benton John B Jr"
        Date = DateTime.Parse "2015-09-13"
        Status = "unqualified"
        Verified = true
        Activity = 17
        Representative =
          { Name = "Ioni Bowcher"
            Image = "ionibowcher.png" }
        Balance = 70663 }
      { Id = 1001
        Name = "Josephine Darakjy"
        Country = { Name = "Egypt"; Code = "eg" }
        Company = "Chanay Jeffrey A Esq"
        Date = DateTime.Parse "2019-02-09"
        Status = "proposal"
        Verified = true
        Activity = 0
        Representative =
          { Name = "Amy Elsner"
            Image = "amyelsner.png" }
        Balance = 82429 }
      { Id = 1002
        Name = "Art Venere"
        Country = { Name = "Panama"; Code = "pa" }
        Company = "Chemel James L Cpa"
        Date = DateTime.Parse "2017-05-13"
        Status = "qualified"
        Verified = false
        Activity = 63
        Representative =
          { Name = "Asiya Javayant"
            Image = "asiyajavayant.png" }
        Balance = 28334 }
      { Id = 1003
        Name = "Lenna Paprocki"
        Country = { Name = "Slovenia"; Code = "si" }
        Company = "Feltz Printing Service"
        Date = DateTime.Parse "2020-09-15"
        Status = "new"
        Verified = false
        Activity = 37
        Representative =
          { Name = "Xuxue Feng"
            Image = "xuxuefeng.png" }
        Balance = 88521 }
      { Id = 1004
        Name = "Donette Foller"
        Country = { Name = "South Africa"; Code = "za" }
        Company = "Printing Dimensions"
        Date = DateTime.Parse "2016-05-20"
        Status = "proposal"
        Verified = true
        Activity = 33
        Representative =
          { Name = "Asiya Javayant"
            Image = "asiyajavayant.png" }
        Balance = 93905 }
      { Id = 1005
        Name = "Simona Morasca"
        Country = { Name = "Egypt"; Code = "eg" }
        Company = "Chapman Ross E Esq"
        Date = DateTime.Parse "2018-02-16"
        Status = "qualified"
        Verified = false
        Activity = 68
        Representative =
          { Name = "Ivan Magalhaes"
            Image = "ivanmagalhaes.png" }
        Balance = 50041 }
      { Id = 1006
        Name = "Mitsue Tollner"
        Country = { Name = "Paraguay"; Code = "py" }
        Company = "Morlong Associates"
        Date = DateTime.Parse "2018-02-19"
        Status = "renewal"
        Verified = true
        Activity = 54
        Representative =
          { Name = "Ivan Magalhaes"
            Image = "ivanmagalhaes.png" }
        Balance = 58706 }
      { Id = 1007
        Name = "Leota Dilliard"
        Country = { Name = "Serbia"; Code = "rs" }
        Company = "Commercial Press"
        Date = DateTime.Parse "2019-08-13"
        Status = "renewal"
        Verified = true
        Activity = 69
        Representative =
          { Name = "Onyama Limba"
            Image = "onyamalimba.png" }
        Balance = 26640 }
      { Id = 1008
        Name = "Sage Wieser"
        Country = { Name = "Egypt"; Code = "eg" }
        Company = "Truhlar And Truhlar Attys"
        Date = DateTime.Parse "2018-11-21"
        Status = "unqualified"
        Verified = true
        Activity = 76
        Representative =
          { Name = "Ivan Magalhaes"
            Image = "ivanmagalhaes.png" }
        Balance = 65369 }
      { Id = 1009
        Name = "Kris Marrier"
        Country = { Name = "Mexico"; Code = "mx" }
        Company = "King Christopher A Esq"
        Date = DateTime.Parse "2015-07-07"
        Status = "proposal"
        Verified = false
        Activity = 3
        Representative =
          { Name = "Onyama Limba"
            Image = "onyamalimba.png" }
        Balance = 63451 }
      { Id = 1070
        Name = "Kallie Blackwood"
        Country = { Name = "Iceland"; Code = "is" }
        Company = "Rowley Schlimgen Inc"
        Date = DateTime.Parse "2017-04-05"
        Status = "unqualified"
        Verified = false
        Activity = 25
        Representative =
          { Name = "Amy Elsner"
            Image = "amyelsner.png" }
        Balance = 13775 } ]

let products =
    [ { Id = "1000"
        Code = "f230fh0g3"
        Name = "Bamboo Watch"
        Description = "Product Description"
        Image = "bamboo-watch.jpg"
        Price = 65
        Category = "Accessories"
        Quantity = 24
        InventoryStatus = "INSTOCK"
        Rating = 5 }
      { Id = "1001"
        Code = "nvklal433"
        Name = "Black Watch"
        Description = "Product Description"
        Image = "black-watch.jpg"
        Price = 72
        Category = "Accessories"
        Quantity = 61
        InventoryStatus = "INSTOCK"
        Rating = 4 }
      { Id = "1002"
        Code = "zz21cz3c1"
        Name = "Blue Band"
        Description = "Product Description"
        Image = "blue-band.jpg"
        Price = 79
        Category = "Fitness"
        Quantity = 2
        InventoryStatus = "LOWSTOCK"
        Rating = 3 }
      { Id = "1003"
        Code = "244wgerg2"
        Name = "Blue T-Shirt"
        Description = "Product Description"
        Image = "blue-t-shirt.jpg"
        Price = 29
        Category = "Clothing"
        Quantity = 25
        InventoryStatus = "INSTOCK"
        Rating = 5 }
      { Id = "1004"
        Code = "h456wer53"
        Name = "Bracelet"
        Description = "Product Description"
        Image = "bracelet.jpg"
        Price = 15
        Category = "Accessories"
        Quantity = 73
        InventoryStatus = "INSTOCK"
        Rating = 4 }
      { Id = "1005"
        Code = "av2231fwg"
        Name = "Brown Purse"
        Description = "Product Description"
        Image = "brown-purse.jpg"
        Price = 120
        Category = "Accessories"
        Quantity = 0
        InventoryStatus = "OUTOFSTOCK"
        Rating = 4 }
      { Id = "1006"
        Code = "bib36pfvm"
        Name = "Chakra Bracelet"
        Description = "Product Description"
        Image = "chakra-bracelet.jpg"
        Price = 32
        Category = "Accessories"
        Quantity = 5
        InventoryStatus = "LOWSTOCK"
        Rating = 3 }
      { Id = "1007"
        Code = "mbvjkgip5"
        Name = "Galaxy Earrings"
        Description = "Product Description"
        Image = "galaxy-earrings.jpg"
        Price = 34
        Category = "Accessories"
        Quantity = 23
        InventoryStatus = "INSTOCK"
        Rating = 5 }
      { Id = "1008"
        Code = "vbb124btr"
        Name = "Game Controller"
        Description = "Product Description"
        Image = "game-controller.jpg"
        Price = 99
        Category = "Electronics"
        Quantity = 2
        InventoryStatus = "LOWSTOCK"
        Rating = 4 }
      { Id = "1009"
        Code = "cm230f032"
        Name = "Gaming Set"
        Description = "Product Description"
        Image = "gaming-set.jpg"
        Price = 299
        Category = "Electronics"
        Quantity = 63
        InventoryStatus = "INSTOCK"
        Rating = 3 } ]