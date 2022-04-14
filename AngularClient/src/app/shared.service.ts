import { Injectable } from '@angular/core';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
readonly APIUrl = "https://localhost:7113/api";
  constructor(private http:HttpClient) { }

  getAllPessoa():Observable<any>{
    return this.http.get<any>(this.APIUrl+'/Pessoa');
  }
  getPessoa(id:any):Observable<any>{
    return this.http.get<any>(this.APIUrl+'/Pessoa/'+id);
  }
  addPessoa(val:any){
    return this.http.post(this.APIUrl+'/Pessoa',val);
  }
  updatePessoa(id:any,val:any){
    return this.http.put(this.APIUrl+'/Pessoa/'+id,val);
  }
  deletePessoa(id:any){
    return this.http.delete(this.APIUrl+'/Pessoa/'+id);
  }

  getAllCidade():Observable<any>{
    return this.http.get<any>(this.APIUrl+'/Cidade');
  }
  getCidade(id:any):Observable<any>{
    return this.http.get<any>(this.APIUrl+'/Cidade/'+id);
  }
  addCidade(val:any){
    return this.http.post(this.APIUrl+'/Cidade',val);
  }
  updateCidade(id:any,val:any){
    return this.http.put(this.APIUrl+'/Cidade/'+id,val);
  }
  deleteCidade(id:any){
    return this.http.delete(this.APIUrl+'/Cidade/'+id);
  }
}
