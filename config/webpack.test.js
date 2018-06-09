var webpack = require('webpack');
var ExtractTextPlugin = require('extract-text-webpack-plugin');
var helpers = require('./helpers');

module.exports = {
    devtool: 'inline-source-map',

    resolve: {
        extensions: ['.ts', '.js']
    },
    module: {
        rules: [
            {
                test: /\.ts$/,
                loaders: ['awesome-typescript-loader' , 'angular2-template-loader']
            },            
            {
                test: /\.html$/,
                loader: 'html-loader'
            },
            {
    s            test: /\.(png|jpe?g|gif|svg|woff|woff2|ttf|eot|ico)$/,
                loader: 'null-loader'
            },
            {
                test: /\.scss$/,
                use: ['style-loader',
                'css-loader',
                'sass-loader']
            },
            {
                test:/\.css$/,
                include: helpers.root('src', 'app'),
                loader: 'raw-loader'
            }
        ]
    },

    plugins: [
        
            new webpack.ContextReplacementPlugin(
              // The (\\|\/) piece accounts for path separators in *nix and Windows
              /angular(\\|\/)core(\\|\/)@angular/,
              helpers.root('./src'), // location of your src
              {} // a map of your routes
            )
        ]

}