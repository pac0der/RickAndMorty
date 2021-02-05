import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CharacterService } from 'src/app/services/character.service';

@Component({
  selector: 'app-character-detail',
  templateUrl: './character-detail.component.html',
  styleUrls: ['./character-detail.component.css']
})
export class CharacterDetailComponent implements OnInit {
  characterId: number;
  character: any = {};
  location: any = {}; 
  constructor(private characterService: CharacterService,
    private route: ActivatedRoute) {
    this.characterId = Number.parseInt(this.route.snapshot.paramMap.get('characterId'));
    this.character.image = '';
    this.location.name = 'Unknown'    
  }

  ngOnInit() {
    this.getCharacter();
  }
  getCharacter() {
    this.characterService.getById(this.characterId).subscribe((d: any) => {
      this.character = d;
      console.log(d);
      if (d.origin.url !== '') {
        this.characterService.getLocation(d.origin.url).subscribe((l: any) => {
          console.log(l);
          this.location = l;
        });
      }
    });
  }
}
