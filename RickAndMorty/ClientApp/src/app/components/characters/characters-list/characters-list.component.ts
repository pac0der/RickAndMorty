import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BaseTableFilter } from 'src/app/models/base-table-filter';
import { CharacterService } from 'src/app/services/character.service';
import { BaseTable } from 'src/app/utils/base-table';

@Component({
  selector: 'app-characters-list',
  templateUrl: './characters-list.component.html',
  styleUrls: ['./characters-list.component.css']
})
export class CharactersListComponent extends BaseTable implements OnInit {
  characters: any;
  filters: BaseTableFilter;

  constructor(private characterService: CharacterService,
    private route: ActivatedRoute) {
    super();
    this.filters = new BaseTableFilter();   
    this.configTable(this.getCharacters, this.filters);
  }

  ngOnInit() {
    this.getCharacters();
  }

  getCharacters() {
    this.characterService.getByPage(this.page).subscribe((d: any) => {
      this.characters = d.results;
      this.totalRows = d.info.count;
    });
  }
}
