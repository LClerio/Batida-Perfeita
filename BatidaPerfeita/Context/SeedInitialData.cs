using BatidaPerfeita.Models;

namespace BatidaPerfeita.Context
{
    public class SeedInitialData
    {
        private readonly AppDbContext _context;

        public SeedInitialData(AppDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Categories.Any() || _context.Products.Any()) return;

            Category Category01 = new Category
            {
                CategoryId = 1,
                Name = "Guitarra",
            };

            Category Category02 = new Category
            {
                CategoryId = 2,
                Name = "Baixo",
            };

            Category Category03 = new Category
            {
                CategoryId = 3,
                Name = "Violão",
            };

            Product Guitarra01 = new Product
            {
                ProductId = 1,
                CategoryId = 1,

                Name = "Fender Player Stratocaster Maple Fingerboard",
                ShortDescription = "Stratocaster com captadores single-coil Alnico V, corpo em alder e braço em maple. Timbre brilhante e versátil.",
                LongDescription = "A Fender Player Stratocaster Maple Fingerboard possui corpo em alder e braço em maple com perfil Modern C. Equipada com três captadores single-coil Alnico V passivos, entrega timbre brilhante, definido e articulado. A ponte tremolo de 2 pivôs proporciona estabilidade e expressividade. Indicada para rock, blues, pop e funk.",
                Price = 8499.90m,
                ImageUrl = "img/Guitarra/imagemtest.png",
                ImageThumbnailUrl = "img/Guitarra/imagemtest.png",
                IsPreferredProduct = true,
                InStock = true
            };
            Product Guitarra02 = new Product
            {
                ProductId = 2,
                CategoryId = 1,

                Name = "Gibson Les Paul Standard 60s",
                ShortDescription = "Les Paul com captadores Burstbucker, corpo em mogno com tampo maple e sustain encorpado.",
                LongDescription = "A Gibson Les Paul Standard 60s apresenta corpo em mogno com tampo em maple AA e braço Slim Taper. Seus captadores humbucker Burstbucker 61 são passivos e entregam timbre quente, encorpado e com excelente sustain. Ideal para rock clássico, hard rock e blues.",
                Price = 18999.90m,
                ImageUrl = "img/Guitarra/imagemtest.png",
                ImageThumbnailUrl = "img/Guitarra/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Guitarra03 = new Product
            {
                ProductId = 3,
                CategoryId = 1,

                Name = "Ibanez RG550 Genesis Collection",
                ShortDescription = "Super Strato com captadores HSH e ponte Floyd Rose. Alta performance para solos rápidos.",
                LongDescription = "A Ibanez RG550 Genesis Collection possui corpo em basswood e braço Wizard em maple, extremamente confortável. Configuração HSH com captadores passivos V7, S1 e V8 oferece versatilidade tonal. Ponte tremolo Edge garante estabilidade em alavancadas. Ideal para metal, shred e rock moderno.",
                Price = 9999.90m,
                ImageUrl = "img/Guitarra/imagemtest.png",
                ImageThumbnailUrl = "img/Guitarra/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Guitarra04 = new Product
            {
                ProductId = 4,
                CategoryId = 1,

                Name = "Fender American Professional II Telecaster",
                ShortDescription = "Telecaster com captadores V-Mod II e timbre clássico brilhante.",
                LongDescription = "A Fender American Professional II Telecaster possui corpo em alder e braço em maple com perfil Deep C. Equipada com captadores single-coil V-Mod II, oferece timbre articulado e brilhante, ideal para country, blues e rock.",
                Price = 13999.90m,
                ImageUrl = "img/Guitarra/imagemtest.png",
                ImageThumbnailUrl = "img/Guitarra/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Guitarra05 = new Product
            {
                ProductId = 5,
                CategoryId = 1,

                Name = "PRS SE Custom 24",
                ShortDescription = "Guitarra versátil com captadores humbucker e acabamento premium.",
                LongDescription = "A PRS SE Custom 24 apresenta corpo em mogno com tampo em maple e braço Wide Thin. Seus captadores humbucker entregam timbre equilibrado, ideal para rock, pop e metal leve.",
                Price = 7499.90m,
                ImageUrl = "img/Guitarra/imagemtest.png",
                ImageThumbnailUrl = "img/Guitarra/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Guitarra06 = new Product
            {
                ProductId = 6,
                CategoryId = 1,

                Name = "Jackson Soloist SLX",
                ShortDescription = "Super Strato com captadores de alto ganho e braço rápido.",
                LongDescription = "A Jackson Soloist SLX possui corpo em poplar e braço em maple com perfil speed neck. Seus captadores humbucker entregam alto ganho, ideal para metal e hard rock.",
                Price = 5999.90m,
                ImageUrl = "img/Guitarra/imagemtest.png",
                ImageThumbnailUrl = "img/Guitarra/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Guitarra07 = new Product
            {
                ProductId = 7,
                CategoryId = 1,
                Name = "ESP LTD EC-1000",
                ShortDescription = "Les Paul moderna com captadores ativos e alto ganho.",
                LongDescription = "A ESP LTD EC-1000 possui corpo em mogno e captadores ativos de alto ganho, ideal para metal moderno e hard rock.",
                Price = 8999.90m,
                ImageUrl = "img/Guitarra/imagemtest.png",
                ImageThumbnailUrl = "img/Guitarra/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Guitarra08 = new Product
            {
                ProductId = 8,
                CategoryId = 1,
                Name = "Gretsch G2622 Streamliner",
                ShortDescription = "Semi-hollow com timbre vintage e encorpado.",
                LongDescription = "A Gretsch G2622 é uma semiacústica com captadores Broad'Tron, ideal para jazz, blues e rock clássico.",
                Price = 5999.90m,
                ImageUrl = "img/Guitarra/imagemtest.png",
                ImageThumbnailUrl = "img/Guitarra/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Guitarra09 = new Product
            {
                ProductId = 9,
                CategoryId = 1,
                Name = "Ibanez RGA42FM",
                ShortDescription = "Super Strato moderna com alto conforto.",
                LongDescription = "A Ibanez RGA42FM possui braço Wizard III e captadores humbucker versáteis.",
                Price = 4499.90m,
                ImageUrl = "img/Guitarra/imagemtest.png",
                ImageThumbnailUrl = "img/Guitarra/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Guitarra10 = new Product
            {
                ProductId = 10,
                CategoryId = 1,
                Name = "Schecter Hellraiser C-1",
                ShortDescription = "Guitarra para metal com captadores ativos.",
                LongDescription = "A Schecter Hellraiser C-1 entrega sustain poderoso e definição em afinações baixas.",
                Price = 7999.90m,
                ImageUrl = "img/Guitarra/imagemtest.png",
                ImageThumbnailUrl = "img/Guitarra/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Guitarra11 = new Product
            {
                ProductId = 11,
                CategoryId = 1,
                Name = "Fender Vintera 50s Stratocaster",
                ShortDescription = "Stratocaster vintage com som clássico.",
                LongDescription = "Modelo inspirado nos anos 50, com captadores single-coil brilhantes.",
                Price = 10999.90m,
                ImageUrl = "img/Guitarra/imagemtest.png",
                ImageThumbnailUrl = "img/Guitarra/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Guitarra12 = new Product
            {
                ProductId = 12,
                CategoryId = 1,
                Name = "Charvel Pro-Mod DK24",
                ShortDescription = "Super Strato com braço rápido e versátil.",
                LongDescription = "A Charvel DK24 combina conforto moderno com captadores de alta definição.",
                Price = 8499.90m,
                ImageUrl = "img/Guitarra/imagemtest.png",
                ImageThumbnailUrl = "img/Guitarra/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Guitarra13 = new Product
            {
                ProductId = 13,
                CategoryId = 1,
                Name = "Epiphone SG Standard",
                ShortDescription = "SG clássica com timbre agressivo.",
                LongDescription = "Modelo leve com captadores humbucker ideais para rock e blues.",
                Price = 3999.90m,
                ImageUrl = "img/Guitarra/imagemtest.png",
                ImageThumbnailUrl = "img/Guitarra/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Guitarra14 = new Product
            {
                ProductId = 14,
                CategoryId = 1,
                Name = "Music Man Majesty",
                ShortDescription = "Guitarra premium para alta performance.",
                LongDescription = "Modelo signature com construção moderna e captação de alto nível.",
                Price = 25999.90m,
                ImageUrl = "img/Guitarra/imagemtest.png",
                ImageThumbnailUrl = "img/Guitarra/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Guitarra15 = new Product
            {
                ProductId = 15,
                CategoryId = 1,
                Name = "Yamaha Pacifica 112V",
                ShortDescription = "Guitarra versátil para iniciantes e intermediários.",
                LongDescription = "A Pacifica 112V oferece excelente custo-benefício com configuração HSS.",
                Price = 2499.90m,
                ImageUrl = "img/Guitarra/imagemtest.png",
                ImageThumbnailUrl = "img/Guitarra/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };


            Product Baixo01 = new Product
            {
                ProductId = 16,
                CategoryId = 2,

                Name = "Fender Player Precision Bass",
                ShortDescription = "Precision Bass passivo com captador split-coil Alnico V e som encorpado tradicional.",
                LongDescription = "O Fender Player Precision Bass apresenta corpo em alder e braço em maple. Seu captador split-coil Alnico V passivo oferece graves fortes e médios presentes. Timbre clássico ideal para rock, punk e blues. Ponte estável de 4 saddles garante sustain consistente.",
                Price = 8999.90m,
                ImageUrl = "img/Baixo/imagemtest.png",
                ImageThumbnailUrl = "img/Baixo/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Baixo02 = new Product
            {
                ProductId = 17,
                CategoryId = 2,

                Name = "Yamaha TRBX305 5-String",
                ShortDescription = "Baixo ativo de 5 cordas com equalização ativa e timbre moderno versátil.",
                LongDescription = "O Yamaha TRBX305 possui corpo em mogno sólido e sistema ativo de 2 bandas. Seus captadores humbucker entregam graves definidos e médios articulados. Com 5 cordas, amplia a extensão de graves, ideal para gospel, pop e metal moderno.",
                Price = 4599.90m,
                ImageUrl = "img/Baixo/imagemtest.png",
                ImageThumbnailUrl = "img/Baixo/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Baixo03 = new Product
            {
                ProductId = 18,
                CategoryId = 2,

                Name = "Cort GB34JJ Jazz Bass",
                ShortDescription = "Jazz Bass passivo com captadores single-coil JJ e timbre equilibrado.",
                LongDescription = "O Cort GB34JJ apresenta corpo em poplar e braço em maple. Equipado com dois captadores single-coil passivos no padrão Jazz Bass, entrega som equilibrado e versátil. Indicado para jazz, funk, blues e pop.",
                Price = 2999.90m,
                ImageUrl = "img/Baixo/imagemtest.png",
                ImageThumbnailUrl = "img/Baixo/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Baixo04 = new Product
            {
                ProductId = 19,
                CategoryId = 2,

                Name = "Ibanez SR300E",
                ShortDescription = "Baixo ativo leve e confortável com timbre moderno.",
                LongDescription = "O Ibanez SR300E possui corpo em nyatoh e circuito ativo com equalização de 3 bandas. Ideal para funk, gospel e pop moderno.",
                Price = 3299.90m,
                ImageUrl = "img/Baixo/imagemtest.png",
                ImageThumbnailUrl = "img/Baixo/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Baixo05 = new Product
            {
                ProductId = 20,
                CategoryId = 2,

                Name = "Music Man StingRay 4",
                ShortDescription = "Baixo icônico com captador humbucker potente.",
                LongDescription = "O Music Man StingRay 4 possui corpo em ash e circuito ativo de 3 bandas. Timbre encorpado com graves profundos e médios marcantes.",
                Price = 15999.90m,
                ImageUrl = "img/Baixo/imagemtest.png",
                ImageThumbnailUrl = "img/Baixo/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Baixo06 = new Product
            {
                ProductId = 21,
                CategoryId = 2,

                Name = "Squier Classic Vibe Jazz Bass 70s",
                ShortDescription = "Jazz Bass com visual vintage e timbre clássico.",
                LongDescription = "O Squier Classic Vibe Jazz Bass 70s possui captadores single-coil passivos e visual inspirado nos anos 70. Ideal para funk, jazz e rock.",
                Price = 3899.90m,
                ImageUrl = "img/Baixo/imagemtest.png",
                ImageThumbnailUrl = "img/Baixo/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Baixo07 = new Product
            {
                ProductId = 22,
                CategoryId = 2,
                Name = "Ibanez BTB745 5-String",
                ShortDescription = "Baixo de 5 cordas com som moderno e definido.",
                LongDescription = "Modelo ativo com grande definição e sustain.",
                Price = 7999.90m,
                ImageUrl = "img/Baixo/imagemtest.png",
                ImageThumbnailUrl = "img/Baixo/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Baixo08 = new Product
            {
                ProductId = 23,
                CategoryId = 2,
                Name = "Yamaha TRB1005J",
                ShortDescription = "Baixo de 5 cordas com circuito ativo.",
                LongDescription = "Graves profundos e médios definidos para performance profissional.",
                Price = 8999.90m,
                ImageUrl = "img/Baixo/imagemtest.png",
                ImageThumbnailUrl = "img/Baixo/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Baixo09 = new Product
            {
                ProductId = 24,
                CategoryId = 2,
                Name = "Fender American Ultra Jazz Bass V",
                ShortDescription = "Jazz Bass de 5 cordas premium.",
                LongDescription = "Modelo profissional com timbre versátil e construção refinada.",
                Price = 17999.90m,
                ImageUrl = "img/Baixo/imagemtest.png",
                ImageThumbnailUrl = "img/Baixo/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Baixo10 = new Product
            {
                ProductId = 25,
                CategoryId = 2,
                Name = "ESP LTD B-1005",
                ShortDescription = "Baixo moderno de 5 cordas para metal.",
                LongDescription = "Captadores ativos com excelente definição.",
                Price = 9999.90m,
                ImageUrl = "img/Baixo/imagemtest.png",
                ImageThumbnailUrl = "img/Baixo/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Baixo11 = new Product
            {
                ProductId = 26,
                CategoryId = 2,
                Name = "Ibanez SR7FMDX 7-String",
                ShortDescription = "Baixo de 7 cordas para extensão máxima.",
                LongDescription = "Modelo moderno com graves profundos e versatilidade tonal.",
                Price = 11999.90m,
                ImageUrl = "img/Baixo/imagemtest.png",
                ImageThumbnailUrl = "img/Baixo/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Baixo12 = new Product
            {
                ProductId = 27,
                CategoryId = 2,
                Name = "Conklin GT-7",
                ShortDescription = "Baixo de 7 cordas com ampla extensão sonora.",
                LongDescription = "Ideal para estilos técnicos e progressivos.",
                Price = 15999.90m,
                ImageUrl = "img/Baixo/imagemtest.png",
                ImageThumbnailUrl = "img/Baixo/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Baixo13 = new Product
            {
                ProductId = 28,
                CategoryId = 2,
                Name = "Dingwall NG3-5",
                ShortDescription = "Baixo de 5 cordas multiescala.",
                LongDescription = "Modelo premium com construção moderna.",
                Price = 22999.90m,
                ImageUrl = "img/Baixo/imagemtest.png",
                ImageThumbnailUrl = "img/Baixo/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Baixo14 = new Product
            {
                ProductId = 29,
                CategoryId = 2,
                Name = "Warwick Corvette 5",
                ShortDescription = "Baixo alemão de 5 cordas com timbre marcante.",
                LongDescription = "Graves encorpados e excelente definição.",
                Price = 18999.90m,
                ImageUrl = "img/Baixo/imagemtest.png",
                ImageThumbnailUrl = "img/Baixo/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Baixo15 = new Product
            {
                ProductId = 30,
                CategoryId = 2,
                Name = "Schecter Stiletto Studio-7",
                ShortDescription = "Baixo de 7 cordas com visual moderno.",
                LongDescription = "Alta definição sonora para músicos exigentes.",
                Price = 13999.90m,
                ImageUrl = "img/Baixo/imagemtest.png",
                ImageThumbnailUrl = "img/Baixo/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };


            Product Violao01 = new Product
            {
                ProductId = 31,
                CategoryId = 3,

                Name = "Yamaha FG800 Dreadnought",
                ShortDescription = "Violão dreadnought com tampo sólido em spruce e timbre equilibrado.",
                LongDescription = "O Yamaha FG800 possui corpo dreadnought com tampo sólido em spruce e laterais em nato. Oferece projeção sonora potente e graves definidos. Ideal para folk, pop e acompanhamento acústico.",
                Price = 1899.90m,
                ImageUrl = "img/Violao/imagemtest.png",
                ImageThumbnailUrl = "img/Violao/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Violao02 = new Product
            {
                ProductId = 32,
                CategoryId = 3,

                Name = "Takamine GD20 Jumbo",
                ShortDescription = "Violão jumbo com tampo em cedar e grande projeção sonora.",
                LongDescription = "O Takamine GD20 apresenta corpo jumbo com tampo em cedar sólido e laterais em mahogany. Proporciona graves profundos e volume elevado, ideal para apresentações ao vivo e estilos como country e worship.",
                Price = 3299.90m,
                ImageUrl = "img/Violao/imagemtest.png",
                ImageThumbnailUrl = "img/Violao/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Violao03 = new Product
            {
                ProductId = 33,
                CategoryId = 3,

                Name = "Taylor 214ce Grand Concert",
                ShortDescription = "Grand Concert eletroacústico com tampo sólido em spruce e captação ativa.",
                LongDescription = "O Taylor 214ce Grand Concert possui tampo sólido em spruce Sitka e laterais em layered rosewood. Equipado com sistema de captação ativa ES2, oferece timbre claro e definido. Excelente para fingerstyle, MPB e apresentações acústicas.",
                Price = 7499.90m,
                ImageUrl = "img/Violao/imagemtest.png",
                ImageThumbnailUrl = "img/Violao/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Violao04 = new Product
            {
                ProductId = 34,
                CategoryId = 3,

                Name = "Martin D-28 Dreadnought",
                ShortDescription = "Violão premium com timbre encorpado e projeção forte.",
                LongDescription = "O Martin D-28 apresenta tampo sólido em spruce e laterais em rosewood. Timbre rico em graves e médios, ideal para folk e country.",
                Price = 24999.90m,
                ImageUrl = "img/Violao/imagemtest.png",
                ImageThumbnailUrl = "img/Violao/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Violao05 = new Product
            {
                ProductId = 35,
                CategoryId = 3,

                Name = "Epiphone EJ-200 Jumbo",
                ShortDescription = "Violão jumbo com grande volume e visual clássico.",
                LongDescription = "O Epiphone EJ-200 possui corpo jumbo com tampo em spruce e timbre encorpado. Excelente para acompanhamento e palco.",
                Price = 3999.90m,
                ImageUrl = "img/Violao/imagemtest.png",
                ImageThumbnailUrl = "img/Violao/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Violao06 = new Product
            {
                ProductId = 36,
                CategoryId = 3,

                Name = "Yamaha APX600",
                ShortDescription = "Violão eletroacústico fino e confortável.",
                LongDescription = "O Yamaha APX600 possui corpo fino e sistema de captação ativo. Ideal para palco e gravações ao vivo.",
                Price = 2899.90m,
                ImageUrl = "img/Violao/imagemtest.png",
                ImageThumbnailUrl = "img/Violao/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Violao07 = new Product
            {
                ProductId = 37,
                CategoryId = 3,
                Name = "Takamine GN93CE",
                ShortDescription = "Violão eletroacústico com ótimo acabamento.",
                LongDescription = "Modelo com captação ativa e timbre equilibrado.",
                Price = 4999.90m,
                ImageUrl = "img/Violao/imagemtest.png",
                ImageThumbnailUrl = "img/Violao/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Violao08 = new Product
            {
                ProductId = 38,
                CategoryId = 3,
                Name = "Yamaha FS800",
                ShortDescription = "Violão compacto com timbre brilhante.",
                LongDescription = "Modelo confortável para estudo e palco.",
                Price = 1599.90m,
                ImageUrl = "img/Violao/imagemtest.png",
                ImageThumbnailUrl = "img/Violao/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Violao09 = new Product
            {
                ProductId = 39,
                CategoryId = 3,
                Name = "Taylor GS Mini",
                ShortDescription = "Violão compacto premium.",
                LongDescription = "Ideal para viagens e apresentações acústicas.",
                Price = 6999.90m,
                ImageUrl = "img/Violao/imagemtest.png",
                ImageThumbnailUrl = "img/Violao/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Violao10 = new Product
            {
                ProductId = 40,
                CategoryId = 3,
                Name = "Yamaha A3R ARE",
                ShortDescription = "Violão eletroacústico dreadnought com timbre equilibrado.",
                LongDescription = "O Yamaha A3R ARE possui tampo sólido em spruce tratado com tecnologia ARE e laterais em rosewood. Equipado com sistema SRT2, entrega som natural e excelente desempenho ao vivo.",
                Price = 5999.90m,
                ImageUrl = "img/Violao/imagemtest.png",
                ImageThumbnailUrl = "img/Violao/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Violao11 = new Product
            {
                ProductId = 41,
                CategoryId = 3,
                Name = "Takamine GD30CE",
                ShortDescription = "Violão eletroacústico com graves definidos e ótimo custo-benefício.",
                LongDescription = "O Takamine GD30CE possui tampo sólido em spruce e laterais em mahogany. Conta com sistema de captação TP-4TD, ideal para palco e gravações.",
                Price = 3799.90m,
                ImageUrl = "img/Violao/imagemtest.png",
                ImageThumbnailUrl = "img/Violao/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Violao12 = new Product
            {
                ProductId = 42,
                CategoryId = 3,
                Name = "Taylor 114ce Grand Auditorium",
                ShortDescription = "Grand Auditorium eletroacústico com timbre claro e definido.",
                LongDescription = "O Taylor 114ce possui tampo sólido em spruce Sitka e laterais em walnut. Equipado com sistema ES2, oferece clareza e projeção para fingerstyle e acordes.",
                Price = 7499.90m,
                ImageUrl = "img/Violao/imagemtest.png",
                ImageThumbnailUrl = "img/Violao/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Violao13 = new Product
            {
                ProductId = 43,
                CategoryId = 3,
                Name = "Fender Redondo Player",
                ShortDescription = "Violão moderno com visual diferenciado e captação Fishman.",
                LongDescription = "O Fender Redondo Player apresenta tampo sólido em spruce e pré-amplificador Fishman Flex. Oferece timbre equilibrado e presença marcante em palco.",
                Price = 4199.90m,
                ImageUrl = "img/Violao/imagemtest.png",
                ImageThumbnailUrl = "img/Violao/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Violao14 = new Product
            {
                ProductId = 44,
                CategoryId = 3,
                Name = "Crafter HD-100 CE",
                ShortDescription = "Dreadnought eletroacústico com ótima projeção sonora.",
                LongDescription = "O Crafter HD-100 CE possui tampo sólido em spruce e laterais em mahogany. Seu sistema de captação ativo proporciona versatilidade para palco.",
                Price = 3299.90m,
                ImageUrl = "img/Violao/imagemtest.png",
                ImageThumbnailUrl = "img/Violao/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };
            Product Violao15 = new Product
            {
                ProductId = 45,
                CategoryId = 3,
                Name = "Guild OM-240CE",
                ShortDescription = "Orchestra Model com timbre equilibrado e ótima definição.",
                LongDescription = "O Guild OM-240CE possui tampo sólido em spruce e laterais em mahogany. Corpo estilo Orchestra Model ideal para dedilhados e estilos acústicos refinados.",
                Price = 6999.90m,
                ImageUrl = "img/Violao/imagemtest.png",
                ImageThumbnailUrl = "img/Violao/imagemtest.png",
                IsPreferredProduct = false,
                InStock = true
            };


            _context.Categories.AddRange(Category01, Category02, Category03);
            _context.Products.AddRange(
                            Guitarra01, Guitarra02, Guitarra03, Guitarra04, Guitarra05,
                            Guitarra06, Guitarra07, Guitarra08, Guitarra09, Guitarra10,
                            Guitarra11, Guitarra12, Guitarra13, Guitarra14, Guitarra15,

                            Baixo01, Baixo02, Baixo03, Baixo04, Baixo05,
                            Baixo06, Baixo07, Baixo08, Baixo09, Baixo10,
                            Baixo11, Baixo12, Baixo13, Baixo14, Baixo15,

                            Violao01, Violao02, Violao03, Violao04, Violao05,
                            Violao06, Violao07, Violao08, Violao09, Violao10,
                            Violao11, Violao12, Violao13, Violao14, Violao15
                        );

            _context.SaveChanges();


        }
    }
}
