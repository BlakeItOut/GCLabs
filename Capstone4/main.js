$(document).ready(function () {
    const items = []

    for(i = 1; i <= 10; i++){
        items.push({
            Name: `Thing${i}`,
            Price: i+.50,
            Quantity: 0,
            get cost() {return this.Price * this.Quantity} 
        })
    }
    let html

    const formatter = new Intl.NumberFormat('en-US', {
        style: 'currency',
        currency: 'USD',
        minimumFractionDigits: 2
    })

    refreshCart()

    function addItem(event){
        items[event.data.itemIndex].Quantity++
        refreshCart()
    }

    function removeItem(event){
        if(items[event.data.itemIndex].Quantity>0){
            items[event.data.itemIndex].Quantity--
            refreshCart()
        }  
    }
    
    function refreshCart(){
        $('#back').attr('id', 'checkout').text('Checkout').click(checkout)
        html = 
        `<table border='1|1'>
            <tr>
                <th>Name</th>
                <th>Price</th>
                <th>Quantity</th>
                <th>Add/Remove</th>
                <th>Cost</th>
            </tr>`;
        for (var i = 0; i < items.length; i++) {
            html+="<tr>"
            html+="<td>"+items[i].Name+"</td>"
            html+="<td>"+formatter.format(items[i].Price)+"</td>"
            html+="<td>"+items[i].Quantity+"</td>"
            html+=`<td><button id="Thing${i+1}Add">+</button>/`
            html+=`<button id="Thing${i+1}Remove">-</button></td>`
            html+="<td>"+formatter.format(items[i].cost)+"</td>"
            html+="</tr>"
        }
        html+=`
            <tr>
                <td></td>
                <td></td>
                <td></td>
                <td>Subtotal</td>
                <td>${formatter.format(sum(items, 'cost'))}</td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
                <td>Tax</td>
                <td>${formatter.format(sum(items, 'cost')*.0625)}</td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
                <td>Total</td>
                <td>${formatter.format(sum(items, 'cost')*1.0625)}</td>
            </tr>
        </table>`
        $('div').html(html)
        for (var i = 0; i < items.length; i++) {
            $(`#Thing${i+1}Add`).click({itemIndex:i}, addItem)
            $(`#Thing${i+1}Remove`).click({itemIndex:i}, removeItem)
        }
    }
    
    function checkout(){
        if(sum(items, 'cost') !== 0){
            $('#checkout').attr('id', 'back').text('back').click(refreshCart)
            html = 
            `<table border='1|1'>
                <tr>
                    <th>Name</th>
                    <th>Price</th>
                    <th>Quantity</th>
                    <th>Cost</th>
                </tr>`;
            for (var i = 0; i < items.length; i++) {
                if(items[i].Quantity>0){
                    html+="<tr>"
                    html+="<td>"+items[i].Name+"</td>"
                    html+="<td>"+formatter.format(items[i].Price)+"</td>"
                    html+="<td>"+items[i].Quantity+"</td>"
                    html+="<td>"+formatter.format(items[i].cost)+"</td>"
                    html+="</tr>"
                }
            }
            html+=`
                <tr>
                    <td></td>
                    <td></td>
                    <td>Subtotal</td>
                    <td>${formatter.format(sum(items, 'cost'))}</td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td>Tax</td>
                    <td>${formatter.format(sum(items, 'cost')*.0625)}</td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td>Total</td>
                    <td>${formatter.format(sum(items, 'cost')*1.0625)}</td>
                </tr>
            </table>`
            $('div').html(html);
        }
    }

    function sum(items, prop){
        return items.reduce( (a, b) => a + b[prop],0);
    }
});