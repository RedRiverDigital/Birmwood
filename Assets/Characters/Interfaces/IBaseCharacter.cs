using UnityEngine;
using System.Collections;

namespace Birmwood.Characters {
	public interface IBaseCharacter {

		string Name {get;set;}
		int Health {get;set;}
		CharacterTypes CharacterType {get;set;}

	}
}
