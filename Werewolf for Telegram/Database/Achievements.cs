﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    [Flags]
    public enum Achievements : long
    {
        [Display(Name = "None"), Description("Você não jogou nenhum jogo ainda!")]
        None = 0,
        [Display(Name = "Bem vindo ao inferno"), Description("Jogue uma partida")]
        WelcomeToHell = 1,
        [Display(Name = "Bem vindo ao hospício"), Description("Jogue uma partida no modo caótico")]
        WelcomeToAsylum = 2,
        [Display(Name = "Paciente com Alzheimer"), Description("Jogue uma partida no modo amnésia")]
        AlzheimerPatient = 4,
        [Display(Name = "VOSE É DESTRUIDORA MESMO EIN BICHA!"), Description("Jogue uma partida com o @Fernando0")]
        OHAIDER = 8,
        [Display(Name = "Espião vs Espião"), Description("Jogue uma partida no modo secreto (sem papéis revelados)")]
        SpyVsSpy = 16,
        [Display(Name = "Explorador"), Description("Jogue no mínimo 2 partidas em 10 grupos diferentes")]
        Explorer = 32,
        [Display(Name = "Linguístico"), Description("Jogue no mínimo 2 partidas em 10 linguagens diferentes")]
        Linguist = 64,
        [Display(Name = "Eu não tenho idéia do que estou fazendo"), Description("Jogue uma partida no modo secreto/amnésia")]
        NoIdeaWhat = 128,
        [Display(Name = "Enoclofobia"), Description("Jogue uma partida com 35 jogadores")]
        Enochlophobia = 256,
        [Display(Name = "Introvertido"), Description("Jogue uma partida de 5 jogadores")]
        Introvert = 512,
        [Display(Name = "Pervertido!"), Description("Jogue uma partida usando um pacote de linguagem NSFW")]
        Naughty = 1024,
        [Display(Name = "Dedicado"), Description("Jogue 100 partidas")]
        Dedicated = 2048,
        [Display(Name = "Obcecado"), Description("Jogue 1000 partidas")]
        Obsessed = 4096,
        [Display(Name = "Aqui está o Jhonny!"), Description("Registre 50 mortes como o Justiceiro")]
        HereJohnny = 8192,
        [Display(Name = "Eu te dou cobertura"), Description("Salve 50 pessoas como o Arcanjo")]
        GotYourBack = 16384,
        [Display(Name = "Masoquista"), Description("Ganhe uma partida como o Nitro")]
        Masochist = 32768,
        [Display(Name = "Hick up!"), Description("Sobreviva uma partida como o Tony Stark (no mínimo 10 jogadores)")]
        Wobble = 65536,
        [Display(Name = "Imperceptível"), Description("Em uma partida de 20 pessoas ou mais, não tenha nenhum voto contra você (e sobreviva)")]
        Inconspicuous = 131072,
        [Display(Name = "Sobrevivente"), Description("Sobreviva 100 partidas")]
        Survivalist = 262144,
        [Display(Name = "Ovelha negra"), Description("Seja linchado na primeira noite em 3 partidas seguidas")]
        BlackSheep = 524288,
        [Display(Name = "Promíscuo"), Description("Como a Viúva Negra, sobreviva por uma partida de 5 ou mais noites sem ficar em casa ou visitando a mesma pessoa mais de uma vez")]
        Promiscuous = 1048576,
        [Display(Name = "Parceiros da S.H.I.E.L.D"), Description("Seja um dos pelo menos dois maçons sobreviventes em uma partida")]
        MasonBrother = 2097152,
        [Display(Name = "Camaleão"), Description("Troque de papel duas vezes em uma partida (conversão para a Hydra não conta)")]
        DoubleShifter = 4194304,
        [Display(Name = "Ei cara, belo tiro"), Description("Como o Gavião arqueiro, use sua flecha após morrer para matar Um cavaleiro ou o Justiceiro")]
        HeyManNiceShot = 8388608,
        [Display(Name = "É por isso que você não para em casa"), Description("Como um Cavaleiro ou agente da Hydra, mate ou converta a Viúva Negra que ficou em casa")]
        DontStayHome = 16777216,
        [Display(Name = "Visão Dupla"), Description("Seja uma dos dois telepatas ao mesmo tempo")]
        DoubleVision = 33554432,
        [Display(Name = "Morte dupla"), Description("Faça parte do final do Gavião Arqueiro / Justiceiro")]
        DoubleKill = 67108864,
        [Display(Name = "Eu deveria saber"), Description("Como o Telepata, revele o Vigia")]
        ShouldHaveKnown = 134217728,
        [Display(Name = "Eu vejo falta de confiança"), Description("Como o Telepata, seja linchado no primeiro dia")]
        LackOfTrust = 268435456,
        [Display(Name = "Domingo sangrento"), Description("Seja uma de 4 vítimas mortas em uma noite")]
        BloodyNight = 536870912,
        [Display(Name = "Trocar de lado funciona"), Description("Troque de papéis em uma partida, e vença")]
        ChangingSides = 1073741824,
        [Display(Name = "Amor proibído"), Description("Vença como casal Cavaleiro / Herói (Herói, não time dos heróis)")]
        ForbiddenLove = 2147483648,
        [Display(Name = "Desenvolvedor"), Description("Tenha um 'pull request' aceito")]
        Developer = 4294967296,
        [Display(Name = "A primeira pedra"), Description("Seja o primeiro a votar por 5 noites em uma única partida")]
        FirstStone = 8589934592,
        [Display(Name = "Deadpool bom"), Description("Como o Deadpool, todas as suas balas acertaram um Cavaleiro, Justiceiro ou agente da Hydra")]
        SmartGunner = 17179869184,
        [Display(Name = "O conhecimento das ruas"), Description("Encontre um Cavaleiro, Justiceiro, ou agente da Hydra diferentes por 4 noites seguidas sendo a Jessica Jones")]
        Streetwise = 34359738368,
        [Display(Name = "Encontro relâmpago"), Description("Deixe o bot escolher você como casal (Encantor falha ao escolher)")]
        OnlineDating = 68719476736,
        [Display(Name = "Mesmo um relógio quebrado acerta duas vezes em um dia"), Description("Sendo a Mística, acerte duas visões até o final da partida")]
        BrokenClock = 137438953472,
        [Display(Name = "Tão perto!"), Description("Como o Nitro, seja empatado pela maioria dos votos")]
        SoClose = 274877906944,
        [Display(Name = "Hail Hydra!"), Description("Seja um dos 10 agentes da Hydra sobreviventes no final da partida")]
        CultCon = 549755813888,
        [Display(Name = "Amor próprio"), Description("Como Encantor, escolha você mesmo como um dos enfeitiçados")]
        SelfLoving = 1099511627776,
        [Display(Name = "Eu deveria ter dito algo"), Description("Como um Cavaleiro, você mata seu amante (a primeira noite não conta)")]
        ShouldveMentioned = 2199023255552,
        [Display(Name = "Nitro Excessivo"), Description("Como o Nitro, tenha todos os votos (menos o seu) contra você")]
        TannerOverkill = 4398046511104,
        [Display(Name = "Justiceiro Samaritano"), Description("Como o Justiceiro, mate no mínimo 3 cavaleiros em uma partida")]
        SerialSamaritan = 8796093022208,
        [Display(Name = "Falha nossa"), Description("Seja o agente da Hydra enviado para tentar converter o Capitão América")]
        CultFodder = 17592186044416,
        [Display(Name = "Cavaleiro Solitário"), Description("Em uma partida caótica de 10 ou mais pessoas, seja o único Cavaleiro e vença")]
        LoneWolf = 35184372088832,
        [Display(Name = "Grupo da morte"), Description("Seja um dos 7 Cavaleiros vivos ao mesmo tempo")]
        PackHunter = 70368744177664,
        [Display(Name = "Salvo por uma bala"), Description("Como um herói, o número de Cavaleiros bate com o número de heróis, porém o jogo não acaba porque o Deadpool ainda tinha uma bala")]
        GunnerSaves = 140737488355328,
        [Display(Name = "Uma Longa Hora"), Description("Sobreviva por pelo menos uma hora em uma partida")]
        LongHaul = 281474976710656,
        [Display(Name = "OH MERD-"), Description("Mate seu amante na primeira noite")]
        OhShi = 562949953421312,
        [Display(Name = "Veterano"), Description("Jogue 500 partidas. Agora você pode jogar no @werewolfvets")]
        Veteran = 1125899906842624
    }

    public static class Extensions
    {
        public static string GetDescription(this Achievements value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
        public static string GetName(this Achievements value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());

            var descriptionAttributes = fieldInfo.GetCustomAttributes(
                typeof(DisplayAttribute), false) as DisplayAttribute[];

            if (descriptionAttributes == null) return string.Empty;
            return (descriptionAttributes.Length > 0) ? descriptionAttributes[0].Name : value.ToString();
        }

        public static IEnumerable<Achievements> GetUniqueFlags(this Enum flags)
        {
            ulong flag = 1;
            foreach (var value in Enum.GetValues(flags.GetType()).Cast<Achievements>())
            {
                ulong bits = Convert.ToUInt64(value);
                while (flag < bits)
                {
                    flag <<= 1;
                }

                if (flag == bits && flags.HasFlag(value))
                {
                    yield return value;
                }
            }
        }
    }
}
