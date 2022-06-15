using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieLand_DataAccess.Migrations
{
    public partial class Refactor_Movie_Overview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Overview",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                column: "Overview",
                value: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                column: "Overview",
                value: "Orphelin en bas âge, Peter Parker est un étudiant de lycée avide avec une vie sociale des plus tranquille doublé d'une attirance pour la malchance. Alors qu'il assiste à une démonstration scientifique, une araignée modifiée génétiquement atterrit sur le corps de Peter et elle le mord. Miraculeusement, Peter hérite des capacités incroyables de l'araignée, le métamorphosant en homme-araignée. Peter constatera par la suite qu'il n'y a qu'une mince ligne entre un homme ordinaire et un héros extraordinaire, une ligne qu'il devra croiser.  D'après le héros de bandes dessinées (1962-..).");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                column: "Overview",
                value: "Deux ans après s'être résolus à fermer la Mystère & Cie, le super-chien Scooby-Doo et ses amis Fred, Daphné, Sammy et Véra se retrouvent sur Spooky Island. Les cinq limiers au flair inimitable ont été appelés sur place après une cascade d'incidents paranormaux dans l'immense parc d'attractions de Spring Break.L'excentrique Emile Mondavarious, le maître de l'île, craint que le site ne soit réellement hanté, et compte sur la joyeuse bande pour résoudre au plus vite ces troublantes énigmes et mettre un terme à la fuite de sa richissime clientèle.Oubliant leurs petits désaccords, les cinq acceptent avec enthousiasme cette périlleuse mission. Faux esprits, monstres bidons, effets spéciaux... Scooby-Doo et ses copains croyaient avoir tout vu. Mais à Spooky Island, ils ne sont pas au bout de leurs surprises.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                column: "Overview",
                value: "Une interprète pour les Nations Unies voit sa vie menacée lorsqu'elle surprend la préparation d'un assassinat et demande l'aide d'un agent fédéral sceptique.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                column: "Overview",
                value: "Monsieur et Madame Smith forment un couple tout ce qu'il y a de plus banal... en apparence du moins. Pourtant, Mr Smith exécute des gens pour une organisation secrète et Mme Smith est tueuse à gage vendant ses services aux plus offrants. Ignorant chacun les activités de leur douce moitié, ils vont se retrouver chacun avec l'autre comme « cible » pour des organisations concurrentes.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                column: "Overview",
                value: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7,
                column: "Overview",
                value: "Lorsque le conservateur en chef du musée du Louvre Jacques Saunière est assassiné, le commissaire Bezu Fache fait appel au professeur de symbologie de Harvard Robert Langdon, de passage à Paris, afin qu'il déchiffre le message crypté rédigé par la victime juste avant sa mort. Or, à première vue, ce code porte à croire que Langdon serait le tueur recherché. Débarque Sophie Neveu, cryptologue pour la police de Paris et petite-fille de Saunière. Sentant que Langdon est pris au piège, la jeune femme organise sa fuite et l'entraîne dans une course de 36 heures entre la France, l'Angleterre et l'Écosse, au cours de laquelle ils seront amenés à découvrir la mission secrète du Prieuré de Sion, dont Saunière était le Grand Maître, ainsi que la véritable nature du Saint-Graal.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 8,
                column: "Overview",
                value: "Alors qu’elle a tout pour être heureuse, Lisa Hanson apprend que son mari a été tué dans un accident de voiture. Le lendemain, elle constate qu’il est bien vivant. Alors simple cauchemar ou annonce d’une tragédie imminente ? Du présent au futur, des morts aux résurrections, Linda perd ses repères avant de comprendre que l’occasion lui est donnée de corriger certaines erreurs du passé…");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 9,
                column: "Overview",
                value: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 10,
                column: "Overview",
                value: "Peter Parker a la grosse tête. Ses victoires antérieures ont fait de son alter ego Spider-Man un héros admiré de tous. Son spectaculaire sauvetage de la fille du chef de police de la ville confirme son statut d’icône. Parallèlement toutefois, Mary-Jane traverse une mauvaise passe, ce que le jeune Peter, aveuglé par l’amour, manque de constater. Contrairement à son ami le milliardaire Harry Osborn, occasionnellement possédé par l’esprit de son défunt père, le Green Goblin. Tandis qu’un nouveau péril menace la ville en la personne de l’Homme de sable, une créature visqueuse s’empare de l’esprit de Peter et y injecte le goût de la vengeance. La mutation est si profonde que la conduite de l’homme-araignée, désormais gainé de noir, inquiète.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 11,
                column: "Overview",
                value: "Le scientifique Bruce Banner vit dans l'ombre, toujours amoureux de la belle Betty Ross, et parcourt la planète à la recherche d'un antidote pour guérir le mal dont il est atteint. Les politiciens qui rêvent d'utiliser ses pouvoirs ne le laissent pas tranquille.De retour à la civilisation, notre brillant docteur est poursuivi par l'Abomination, un monstre démoniaque fait d'adrénaline et d'agressivité et dont les pouvoirs concordent avec ceux de Hulk. Une lutte digne des plus grandes bandes dessinées éclate lorsque Banner doit faire appel à Hulk pour sauver New York de la destruction totale.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 12,
                column: "Overview",
                value: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 13,
                column: "Overview",
                value: "En 1959, dans la cour d'une école primaire de la banlieue de Boston, une capsule scellée contenant des dessins d'enfants est mise en terre. Cinquante ans plus tard, on l'exhume afin d'en distribuer le contenu aux écoliers. Plutôt que de recevoir un dessin, Caleb Koestler se retrouve avec une feuille noircie de chiffres. John, son père astrophysicien, s'intéresse au document mystérieux et découvre, consterné, que ce dernier a prédit avec exactitude une série de catastrophes survenues depuis. En traquant les origines du document, John fait la connaissance de Diana Wayland et de sa fille Abby qui, comme Caleb, semble être en contact avec des êtres étranges et inquiétants. À mesure que s'accumulent les tragédies, John comprend que la dernière série de chiffres du document annonce rien de moins que la fin du monde.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 14,
                column: "Overview",
                value: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 15,
                column: "Overview",
                value: "Une antique confrérie secrète parmi les plus puissantes de l'Histoire, les \"Illuminati\", qui s'était jurée autrefois d'anéantir l'Église catholique, est de retour. Cette fois, elle est sur le point de parvenir à son but : Robert Langdon, expert en religions d'Harvard, en a la certitude. Langdon a peu de temps pour comprendre ce qui se trame contre le Vatican et déjouer ces nouveaux crimes. Une course contre la montre et contre les tueurs qui démarre tel un jeu de piste : des églises romaines aux cryptes enfouies, des catacombes les plus profondes aux majestueuses cathédrales... Pour l'aider à comprendre toutes ces énigmes, Langdon va rencontrer Vittoria Vetra, une scientifique aussi belle que mystérieuse. Cette fois, il sait à qui il se confronte. Cette enquête diabolique est un piège, chaque secret est une clé, chaque révélation un danger...");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 16,
                column: "Overview",
                value: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 17,
                column: "Overview",
                value: "Eddie Morra est un auteur raté qui habite un appartement crasseux et qui vient tout juste de vivre une séparation difficile. Il rencontre un jour son ancien beau-frère qui lui propose une solution à tous ses problèmes : une petite pilule magique qui éveille certaines parties du cerveau pour donner accès à un nombre inimaginable d'informations et ainsi rendre surdoué et puissant. Après avoir avalé l'un de ces comprimés, il rédige près du tiers de son roman. Lorsqu'il retrouve son fournisseur mort dans son appartement, il vole les cachets illicites et doit maintenant assumer les effets secondaires et gérer la colère de nombreux ennemis.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 18,
                column: "Overview",
                value: "Dans un univers aussi vaste que mystérieux, une force aussi petite que puissante est en place depuis des siècles : des protecteurs de la paix et de la justice appelés Green Lantern Corps, une confrérie de guerriers qui a juré de maintenir l’ordre intergalactique, et dont chaque membre porte un anneau lui conférant des super-pouvoirs. Mais quand un ennemi du nom de Parallax menace de rompre l’équilibre entre les forces de l’univers, leur destin et celui de la Terre repose sur leur dernière recrue, le premier humain jamais choisi : Hal Jordan.Les Green Lanterns ont un peu de respect pour les humains, qui n’ont jamais exploité les pouvoirs infinis de l’anneau auparavant. Mais Hal possède, une chose qu’aucun des autres membres n’a jamais eu : son humanité. Soutenu par son amour d’enfance, Hal doit rapidement maîtriser ses nouveaux pouvoirs et vaincre ses peur, pour prouver qu’il n’est pas que la clé pour vaincre Parallax… mais peut-être le plus grand Green Lantern de tous les temps.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 19,
                column: "Overview",
                value: "Tombé en disgrâce, l'agent secret britannique Johnny English s'est réfugié dans un monastère tibétain en rêvant de reprendre du service. Son souhait est sur le point de se réaliser lorsqu'on ses supérieurs font appel à lui pour une dangereuse mission. Le premier ministre chinois est menacé de mort et un seul homme peut faire toute la lumière sur ce complot d'envergure internationale. Au fil de son enquête, l'espion aux méthodes très peu orthodoxes découvre que la compagnie Vortex se trouve derrière cette conspiration. Pour l'arrêter, il devra mettre la main sur trois clés, ce qui obligera une taupe à se dévoiler.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 20,
                column: "Overview",
                value: "Sherlock Holmes a toujours été le plus brillant de sa classe… jusqu'à maintenant. Car un nouvel grand esprit criminel s'est fait remarquer en Europe : le professeur Moriarty. Non seulement il est l’égal intellectuel de Holmes, mais sa capacité pour le mal, couplée à une absence totale de conscience, pourrait effectivement lui donner l'avantage face au détective de renom. Lorsque le prince héritier d'Autriche est retrouvé mort, les preuves, telle qu'interprétées par l'inspecteur Lestrade, pointe le suicide. Sauf que Sherlock Holmes en a lui déduit un assassinat… qui ne pourrait être qu'une seule pièce d'un puzzle plus vaste et de beaucoup plus mauvais augure, conçu par le professeur Moriarty.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 21,
                column: "Overview",
                value: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 22,
                column: "Overview",
                value: "Après avoir été piqué par une araignée, un jeune homme timide se transforme en superhéros. Déterminé à combattre le mal, il affronte un scientifique qui menace New York.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 23,
                column: "Overview",
                value: "Modeste ouvrier, Douglas Quaid rêve de s'évader de sa vie frustrante. L'implantation de souvenirs que propose la société Rekall lui paraît l'échappatoire idéale. S'offrir des souvenirs d'agent secret serait parfait... Mais lorsque la procédure d'implantation tourne mal, Quaid se retrouve traqué par la police. Il ne peut plus faire confiance à personne, sauf peut-être à une inconnue qui travaille pour une mystérieuse résistance clandestine. Très vite, la frontière entre l'imagination et la réalité se brouille. Qui est réellement Quaid, et quel est son destin ?");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 24,
                column: "Overview",
                value: "Le maire de New York demande à un ex-policier d'enquêter sur l'aventure de sa femme, mais le détective privé découvre des manigances et une campagne politiques sinistres.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 25,
                column: "Overview",
                value: "Trahi par ses complices à la suite d'un cambriolage dans une foire agricole, Parker est laissé pour mort sur le bord d'une route de campagne. Évidemment bien en vie, ce dernier entreprend de se venger dès son réveil afin de récupérer sa part du butin. Le criminel retrouvera ses anciens acolytes dans le luxueux quartier de West Palm Beach en Floride, où ces derniers se sont installés en vue du vol d'une importante collection de bijoux. Parker sera alors aidé par Leslie, une agente immobilière se remettant difficilement d'un divorce particulièrement éprouvant, qui espère bien obtenir un pourcentage des avoirs que son nouvel ami compte tirer de toute cette histoire.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 26,
                column: "Overview",
                value: "« Les Quatre Cavaliers », un groupe de brillants magiciens et illusionnistes, vient de donner deux spectacles de magie époustouflants: le premier en braquant une banque sur un autre continent, le deuxième en transférant la fortune d'un banquier véreux sur les comptes en banque du public. Deux agents spéciaux du FBI et d'Interpol sont déterminés à les arrêter avant qu'ils ne mettent à exécution leur promesse de réaliser des braquages encore plus audacieux. Ils font appel à Thaddeus, spécialiste reconnu pour expliquer les tours de magie les plus sophistiqués. Alors que la pression s'intensifie, et que le monde entier attend le spectaculaire tour final des Cavaliers, la course contre la montre commence.  Coproduction États-Unis/France.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 27,
                column: "Overview",
                value: "Un petit garçon découvre qu'il possède des pouvoirs surnaturels et qu'il n'est pas né sur Terre. Plus tard, il s'engage dans un périple afin de comprendre d'où il vient et pourquoi il a été envoyé sur notre planète. Mais il devra devenir un héros s'il veut sauver le monde de la destruction totale et incarner l'espoir pour toute l'humanité.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 28,
                column: "Overview",
                value: "Au cours d'un vol de routine, Bill Marks, un maréchal de l'air alcoolique et désabusé, reçoit un message anonyme d'un passager menaçant de tuer une personne se trouvant à bord de l'appareil toutes les vingt minutes, et ce, jusqu'à ce que les autorités acceptent de transférer 150 millions de dollars dans un compte bancaire. Étant le seul à prendre la menace au sérieux, Bill cherche tant bien que mal à découvrir qui se cache derrière pareille machination. L'homme de loi réalise toutefois trop tard qu'il est victime d'un coup monté, chacune de ses actions contribuant au chaos et aidant directement la cause de l'individu qu'il tente d'arrêter.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 29,
                column: "Overview",
                value: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 30,
                column: "Overview",
                value: "Maintenant détective privé, l'ancien policier Matthew Scudder se voit confier le mandat de traquer ceux qui ont assassiné la femme d’un trafiquant de drogue.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 31,
                column: "Overview",
                value: "Nicky rencontre Jess dans un bar un soir. Cette dernière le convainc de devenir sa stagiaire dans le crime. Ensemble, ils escroquent de nombreuses personnes et amassent une fortune colossale. Un jour, après avoir accompli un gros coup, Nicky abandonne Jess dans un taxi et lui demande de quitter la ville, ce qu'elle fait. Trois ans plus tard, à Buenos Aires, Nicky est engagé par un pilote automobile qui lui demande de vendre un faux logiciel à son compétiteur le plus féroce afin qu'il le batte sur la piste. Il est sur le point de réussir sa mission quand Jess apparaît.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 32,
                column: "Overview",
                value: "L'heure de la vengeance a sonné pour Deckard Shaw, qui veut réparer l'affront fait à son frère. Il s'en prend d'abord à l'agent Hobbs en le blessant sérieusement, puis à Han qui se trouve à Tokyo. Après avoir survécu à un colis piégé, Dominic et son beau-frère Brian décident de prendre les armes et de réunir leur équipe de choc. Au volant de quelques-unes des automobiles les plus puissantes de la planète, ils tentent de retrouver leur ennemi juré. Le chef d'une escouade spéciale a la solution à leur problème et il est prêt à aider Dominic à condition que ce dernier remplisse une mission extrêmement dangereuse.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 33,
                column: "Overview",
                value: "Un an après le célèbre spectacle à la Robin des bois qui leur valut les foudres du FBI et l’adulation du public, Les Quatre Cavaliers reviennent sur scène afin de dévoiler les pratiques crapuleuses d’un magnat de l’informatique. Mais l’homme derrière leur fameux acte de disparition n’est autre que Walter Mabry, un prodige de l’informatique qui les poussera à tenter un braquage impossible afin de sauver leur réputation et révéler celui qui se cache derrière le rideau depuis le tout début.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 34,
                column: "Overview",
                value: "La traque de Jason Bourne par les services secrets américains se poursuit. Des îles Canaries à Londres en passant par Las Vegas...");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 35,
                column: "Overview",
                value: "Le professeur Robert Langdon se réveille, amnésique, dans un hôpital de Florence. Après qu'une policière débarque dans sa chambre en tentant de l'assassiner, la docteure Sienna Brooks le prend sous son aile. Ensemble, il découvre qu'un scientifique du nom de Bertrand Zobrist a conçu une arme bactériologique afin d'éliminer plus de la moitié de la population mondiale pour, croit-il, empêcher une surpopulation qui mènerait à l'anéantissement de l'espèce humaine. Robert et Sienna se lancent alors dans une course contre la montre à travers l'Europe afin d'empêcher le virus de se répandre et que le pire se produise.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 36,
                column: "Overview",
                value: "Les éclats d'un téléphone portable se logent dans le cerveau d'un adolescent qui peut ainsi contrôler les dispositifs électroniques et utiliser ce pouvoir pour se venger.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 37,
                column: "Overview",
                value: "Emballé par son expérience avec les Avengers, le jeune Peter Parker retourne chez lui où il vit avec sa tante May, sous l’œil vigilant de son nouveau mentor Tony Stark. Peter essaie de retourner à sa routine quotidienne – distrait par le désir de prouver qu’il est plus que l’araignée sympa du quartier. Mais avec l’arrivée du crapuleux Vautour, tout ce que Peter tient à cœur sera menacé.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 38,
                column: "Overview",
                value: "Un redoutable tueur à gages est contraint de témoigner contre son ancien employeur devant la Cour internationale de justice de La Haye. Interpol est alors chargée de l’escorter jusqu’aux Pays-Bas et engage le meilleur garde du corps du métier pour mener à bien cette mission. Mais c’était sans savoir que depuis des années, les deux hommes s’opposent : les voilà désormais obligés de s’associer pour tenter de survivre aux pires épreuves… De l’Angleterre à La Haye, ils vont vivre une aventure délirante, une succession infernale de tentatives de meurtre, de courses-poursuites pour échapper à un dictateur d’Europe de l’Est prêt à tout pour les éliminer.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 39,
                column: "Overview",
                value: "Spencer, Fridge, Bethany et Martha sont quatre élèves du secondaire qui n'ont absolument rien en commun. Un jour, ils se retrouvent ensemble en retenue et découvrent l'existence d'un étrange jeu vidéo, appelé Jumanji, auquel ils décident de jouer. Rapidement, les adolescents sont aspirés dans le jeu et deviennent l'avatar qu'ils ont précédemment sélectionné. Pour revenir dans le monde réel, ils devront franchir tous les niveaux et gagner la partie. Bien des embûches les attendent sur leur route et ils n'ont chacun que trois vies pour réussir.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 40,
                column: "Overview",
                value: "Des symbiotes débarquent sur la Terre, parmi eux, Venom, qui va s'allier avec Eddie Brock. De son côté, un puissant scientifique tente de faire évoluer l'humanité avec les symbiotes, le duo d'anti-héros va devoir tout faire pour l'arrêter !");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 41,
                column: "Overview",
                value: "Lors d'un voyage en Europe, un policier de New York et sa femme coiffeuse tentent de résoudre un meurtre déconcertant à bord du yacht d'un milliardaire.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 42,
                column: "Overview",
                value: "Depuis que les Avengers ont sauvé la planète, tout est redevenu comme avant. Peter Parker a retrouvé son ancienne vie : celle d'un adolescent qui doit composer avec l'école et ses béguins amoureux. Son alter ego Spider-Man a besoin de vacances et il ne répond même pas aux appels de Nick Fury. Lors d'un séjour scolaire en Europe, il voit apparaître un monstre qui saccage tout sur son passage. Heureusement, cette entité est tenue en échec par Mysterio. Voilà un allié idéal pour Spider-Man, qui s'enfonce dans une véritable crise identitaire. Iron Man n'est plus là pour le protéger et l'univers a besoin d'un véritable superhéros.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 43,
                column: "Overview",
                value: "Luke Hobbs est un agent fédéral qui habite Los Angeles en compagnie de sa fille. Deckard Shaw est un mercenaire britannique qui visite régulièrement sa mère en prison. Ce sont surtout deux ennemis jurés qui ne sont pas capables de se supporter. Ils n'auront pas le choix d'enterrer momentanément la hache de guerre et de travailler ensemble afin de retrouver un virus qui a été dérobé par une agente du MI6. Hattie a disparu dans la nature, après qu'un terroriste mi-humain mi-robot ait décimé son équipe. Ce dernier est prêt à tout afin de mettre la main sur cette arme capable de décimer la moitié de l'humanité.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 44,
                column: "Overview",
                value: "Dani Ramos, 21 ans, mène une vie tranquille à Mexico avec son frère et son père. Elle voit sa vie complètement bouleversée lorsqu'un Terminator (un indestructible REV 9) est envoyé du futur pour l'éliminer. Heureusement, une humaine au physique augmentée débarque au même moment pour la protéger. Les deux femmes seront aussi aidées par la redoutable Sarah Connor, qui traque les Terminator depuis des décennies. Ensemble, elles tâcheront de trouver un moyen d'éliminer le Rev-9 et ainsi protéger Dani, qui tient le sort de l'humanité entre ses mains.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 45,
                column: "Overview",
                value: "Pour échapper à ses ennemis, le petit Sonic est projeté dans notre monde. Il mène une existence paisible, mais solitaire pendant dix longues années jusqu'à ce que sa vie soit à nouveau menacée. Pour ne pas être capturé par le vilain docteur Robotnik, Sonic devra se rendre à San Francisco afin de récupérer les anneaux qui lui permettront de se sauver dans une nouvelle dimension. L'agent de police Tom Wachowski, que Sonic observe dans l'ombre depuis des années, l'accompagnera dans son périple. Les deux nouveaux amis vivront bien des aventures sur la route les menant jusqu'en Californie.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 46,
                column: "Overview",
                value: "Spenser, ancien policier et ex-détenu, fait équipe avec l'aspirant combattant Hawk pour mettre au grand jour une conspiration liée à la mort de deux policiers de Boston.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 47,
                column: "Overview",
                value: "L’enquêteur Jacob Kanon est poussé dans une course contre la montre pour retrouver le tueur en série responsable du meurtre de sa fille.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 48,
                column: "Overview",
                value: "Après avoir bouclé des centaines d’enquêtes et avoir partagé tout autant d’aventures, Scooby et la bande de Mystères associés doivent faire face à la plus grande énigme jamais rencontrée : un complot visant à relâcher le fantôme du chien cerbère dans le monde. Alors qu’elle mène une course contre la montre pour empêcher cette apocalypse canine, la bande de fins limiers découvre l’héritage secret et la destinée grandiose et insoupçonnée de Scooby.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 49,
                column: "Overview",
                value: "Quatre guerriers immortels qui protègent l'humanité depuis des siècles sont traqués pour leurs pouvoirs mystérieux au moment où ils trouvent une nouvelle immortelle.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 50,
                column: "Overview",
                value: "Que feriez-vous si vos parents étaient enlevés par une bande de voleurs? Vous partiriez pour une aventure nocturne avec votre équipement d'espionnage, tout simplement!");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 51,
                column: "Overview",
                value: "À la recherche de sa mère disparue, l'ado intrépide Enola Holmes utilise ses talents de détective pour déjouer son grand frère Sherlock et aider un lord en cavale.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 52,
                column: "Overview",
                value: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 53,
                column: "Overview",
                value: "Le garde du corps Michael Bryce et le tueur à gages Darius Kincaid, duo dangereux et improbable, sont de retour afin de remplir une nouvelle mission quasi impossible. Toujours dépouillé de sa cote triple A et observé de tous, Bryce se voit forcé de reprendre le boulot par la femme de Darius, l’explosive et imprévisible Sonia Kincaid. Alors que Bryce est poussé à la limite par les cibles qu’il doit protéger, le trio se voit entraîné dans un complot international où il est l’ultime chance pour l’Europe d’éviter le chaos total.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 54,
                column: "Overview",
                value: "Dans cet antépisode du film premier film, une mystérieuse femme recrute Dieter, employé de banque, afin de braquer des coffres-forts inviolables à travers l'Europe.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 55,
                column: "Overview",
                value: "Après s'être écrasé par erreur en 2022, le pilote et voyageur temporel Adam Reed fait équipe avec son soi de 12 ans afin de sauver le monde à venir.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Overview",
                table: "Movies");
        }
    }
}
