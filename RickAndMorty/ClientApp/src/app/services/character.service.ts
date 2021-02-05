import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CharacterService {

  constructor(private http: HttpClient) { }

  getByPage(page: number){
    return this.http.get(`https://localhost:5001/api/Character/GetByPage/${page}`);
  }

  getById(id: number){
    return this.http.get(`https://localhost:5001/api/Character/GetById/${id}`);
  }
  getLocation(url: string){
    return this.http.get(url);
  }
}
