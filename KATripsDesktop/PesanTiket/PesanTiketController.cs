using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Velacro.Api;
using Velacro.Basic;

namespace KATripsDesktop.PesanTiket {
    public class PesanTiketController : MyController {
        public PesanTiketController(IMyView _myView) : base(_myView) { }

        public async void pesantiket(
            string _kelas_kereta,
            string _waktu_berangkat,
            string _waktu_tiba,
            string _stasiun_awal,
            string _stasiun_tiba,
            string _kode_gerbang,
            string _jumlah_kursi,
            string _harga_tiket)
        {
            var client = new ApiClient("http://api.katrips.me/");
            var request = new ApiRequestBuilder();

            string token = "";
            var req = request
                .buildHttpRequest()
                .addParameters("kelas_kereta", _kelas_kereta)
                .addParameters("waktu_berangkat", _waktu_berangkat)
                .addParameters("waktu_tiba", _waktu_tiba)
                .addParameters("stasiun_awal", _stasiun_awal)
                .addParameters("stasiun_tiba", _stasiun_tiba)
                .addParameters("kode_gerbang", _kode_gerbang)
                .addParameters("jumlah_kursi", _jumlah_kursi)
                .addParameters("harga_tiket", _harga_tiket)
                .setEndpoint("api/admin/tiket/create/")
                .setRequestMethod(HttpMethod.Post);
            client.setOnSuccessRequest(setViewPesanTiketStatus);
            var response = await client.sendRequest(request.getApiRequestBundle());

        }

        private void setViewPesanTiketStatus(HttpResponseBundle _response)
        {
            if (_response.getHttpResponseMessage().Content != null)
            {
                string status = _response.getHttpResponseMessage().ReasonPhrase;
                getView().callMethod("setTambahStatus", status);
            }
        }
    }
}
