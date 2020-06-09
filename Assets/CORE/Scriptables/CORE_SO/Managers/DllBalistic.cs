using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DllBalistic : ScriptableObject
{
	public string TipoSuperficieImpactada;
	public string TipoHole;
	public string Tipoparticulas;
	public string TipoDecal;

	public DBParticulas DBPArticulas_;





	public void Impactar () {
		

		DetecSuperficieImpacto(); 
		InstanciaHole();
		InstanciaDecal();
		InstanciaParticulas();
	}
	public void DetecSuperficieImpacto() { } //Casos
	public void InstanciaHole() { }
	public void InstanciaDecal() { }
	public void InstanciaParticulas() { } //Casos depende del material o del tag

}
