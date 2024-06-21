using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld() 
        { 
            World newWorld = new World();

            newWorld.AddLocation(-2, -1, "Campo do Fazendeiro",
                "Há fileiras de milho crescendo aqui, com ratos gigantes escondidos entre elas",
                "FarmFields.png");

            newWorld.LocationAt(-2, -1).AddMonster(2, 100);

            newWorld.AddLocation(-1, -1, "Casa do Fazendeiro",
                "Esta é a casa do seu vizinho, Fazendeiro Ted.",
                "Farmhouse.png");

            newWorld.AddLocation(0, -1, "Lar",
                "Esta é a sua casa",
                "Home.png");

            newWorld.AddLocation(-1, 0, "Loja de Trocas",
                "A loja de Susan, a comerciante.",
                "Trader.png");

            newWorld.AddLocation(0, 0, "Praça da Cidade",
                "Você vê uma fonte aqui.",
                "TownSquare.png");

            newWorld.AddLocation(1, 0, "Portão da Cidade",
                "Há um portão aqui, protegendo a cidade de aranhas gigantes.",
                "TownGate.png");

            newWorld.AddLocation(2, 0, "Floresta de Aranhas",
                "As árvores nesta floresta estão cobertas de teias de aranha.",
                "SpiderForest.png");

            newWorld.LocationAt(2,0).AddMonster(3, 100);

            newWorld.AddLocation(0, 1, "Cabana da Herborista",
                "Você vê uma pequena cabana, com plantas secando no telhado.",
                "HerbalistsHut.png");

            newWorld.LocationAt(0,1).QuestAvailableHere.Add(QuestFactory.GetQuestByID(1));

            newWorld.AddLocation(0, 2, "Jardim da Herborista",
                "Há muitas plantas aqui, com cobras escondidas atrás delas.",
                "HerbalistsGarden.png");

            newWorld.LocationAt(0,2).AddMonster(1, 100);

            return newWorld;

        }
    }
}
