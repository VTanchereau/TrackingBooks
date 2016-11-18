using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modele
{
    public class TriFusion
    {
        public static List<List<String>> Trier(List<List<String>> lstExemplairesAffiches)
        {
            int debutPremiereMoitie = 0;
            int nbElementsPremierePartie = lstExemplairesAffiches.Count / 2;
            int debutSecondeMoitie = nbElementsPremierePartie;
            int nbElementsSecondeMoitie = lstExemplairesAffiches.Count- nbElementsPremierePartie;
            List<List<String>> lstPremiereMoitie = lstExemplairesAffiches.GetRange(debutPremiereMoitie, nbElementsPremierePartie);
            List<List<String>> lstSecondeMoitie = lstExemplairesAffiches.GetRange(debutSecondeMoitie, nbElementsSecondeMoitie);

            if (lstPremiereMoitie.Count > 1)
            {
                lstPremiereMoitie = Trier(lstPremiereMoitie);
            }
            if (lstSecondeMoitie.Count > 1)
            {
                lstSecondeMoitie = Trier(lstSecondeMoitie);
            }
            List<List<String>> lstRetour = Fusionner(lstPremiereMoitie, lstSecondeMoitie);
            return lstRetour;
        }

        public static List<List<String>> Fusionner(List<List<String>> liste1, List<List<String>> liste2)
        {
            List<List<String>> lstFusionnee = new List<List<string>>();
            int count1 = 0;
            int count2 = 0;

            while (true)
            {
                if (count1 == liste1.Count)
                {
                    lstFusionnee.AddRange(liste2.GetRange(count2, liste2.Count - count2));
                    break;
                }
                if (count2 == liste2.Count)
                {
                    lstFusionnee.AddRange(liste1.GetRange(count1, (liste1.Count - count1)));
                    break;
                }

                List<String> exemplaire1 = liste1[count1];
                List<String> exemplaire2 = liste2[count2];

                if (exemplaire1[0].CompareTo(exemplaire2[0]) < 0)
                {
                    lstFusionnee.Add(exemplaire1);
                    count1++;
                }
                else
                {
                    lstFusionnee.Add(exemplaire2);
                    count2++;
                }
            }

            return lstFusionnee;
        }
    }
}
